using UnityEngine;  
using System.Collections;  

public class MicInput : MonoBehaviour   
{  
	private AudioClip c;
	private AudioSource audio;

	public void Start(){ 
		Debug.Log ("start");
		audio = GetComponent<AudioSource> ();
	}

//	public void Start(){ 
//		audio = GetComponent<AudioSource>(); 
//		c = Microphone.Start (null, true, 300, 44100);
//		while (!(Microphone.GetPosition(null) > 0)) {}
//		audio.PlayOneShot (c);
//	}

	int lastSample = 0;
	private bool notRecording = true;
	private bool sending = false;

	void FixedUpdate()
	{
		Debug.Log ("fixed update");
		// If there is a connection
		if (GetComponent<PhotonView>().isMine) {
			if (notRecording) {
				Debug.Log ("recording");
				notRecording = false;
				c = Microphone.Start (null, true, 100, 44100);
				sending = true;
			} else if (sending) {
				Debug.Log ("sending");
				int pos = Microphone.GetPosition (null);
				int diff = pos - lastSample;
			
				if (diff > 0) {
					Debug.Log ("diff");
					float[] samples = new float[diff * c.channels];
					c.GetData (samples, lastSample);
					byte[] ba = ToByteArray (samples);
					GetComponent<PhotonView> ().RPC ("Send", PhotonTargets.All, ba, c.channels);
					Debug.Log (Microphone.GetPosition (null).ToString ());
				}
				lastSample = pos;
			}
		}
	}
	
	[PunRPC]
	public void Send(byte[] ba, int chan) {
		Debug.Log ("rpc");
		float[] f = ToFloatArray(ba);
		Debug.Log (f);
		audio.clip = AudioClip.Create("", f.Length, chan, 44100,true,false);
		audio.clip.SetData(f, 0);
		if (!audio.isPlaying) audio.Play();
		
	}
	// Used to convert the audio clip float array to bytes
	public byte[] ToByteArray(float[] floatArray) {
		Debug.Log ("tobytearray");
		int len = floatArray.Length * 4;
		byte[] byteArray = new byte[len];
		int pos = 0;
		foreach (float f in floatArray) {
			byte[] data = System.BitConverter.GetBytes(f);
			System.Array.Copy(data, 0, byteArray, pos, 4);
			pos += 4;
		}
		return byteArray;
	}
	// Used to convert the byte array to float array for the audio clip
	public float[] ToFloatArray(byte[] byteArray) {
		Debug.Log ("tofloatarray");
		int len = byteArray.Length / 4;
		float[] floatArray = new float[len];
		for (int i = 0; i < byteArray.Length; i+=4) {
			floatArray[i/4] = System.BitConverter.ToSingle(byteArray, i);
		}
		return floatArray;
	}

} 