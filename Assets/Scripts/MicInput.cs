using UnityEngine;  
using System.Collections;  

public class MicInput : MonoBehaviour   
{  
	private AudioClip c;
	private AudioSource audio;

	private static int freq = 8000;//44100;
	private int lastSample = 0;
	private float timer = 0;

	public void Start(){ 
		if (GetComponent<PhotonView> ().isMine) {
			audio = GetComponent<AudioSource> ();
			c = Microphone.Start (null, true, 100, freq);
			while(Microphone.GetPosition(null) < 0) {}
		}
	}

	void Update()
	{
		timer += Time.deltaTime;
		if (GetComponent<PhotonView>().isMine && timer > .5f) {
			timer = 0;
			int pos = Microphone.GetPosition (null);
			int diff = pos - lastSample;
		
			if (diff > 0) {
				float[] samples = new float[diff * c.channels];
				c.GetData (samples, lastSample);
				byte[] ba = ToByteArray (samples);
				GetComponent<PhotonView> ().RPC ("Send", PhotonTargets.All, ba, c.channels);
			}
			lastSample = pos;
		}
	}
	
	[PunRPC]
	public void Send(byte[] ba, int chan) {
		float[] f = ToFloatArray(ba);
		audio.clip = AudioClip.Create("", f.Length, chan, freq,true,false);
		audio.clip.SetData(f, 0);
		if (!audio.isPlaying) audio.Play();
		
	}
	// Used to convert the audio clip float array to bytes
	public byte[] ToByteArray(float[] floatArray) {
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
		int len = byteArray.Length / 4;
		float[] floatArray = new float[len];
		for (int i = 0; i < byteArray.Length; i+=4) {
			floatArray[i/4] = System.BitConverter.ToSingle(byteArray, i);
		}
		return floatArray;
	}

} 