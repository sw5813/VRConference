using UnityEngine;  
using System.Collections;

public class MicInput : MonoBehaviour   
{  
	private AudioClip c;
	private AudioSource audio;

	private static int freq = 8000;//44100;
	private int lastSample = 0;
	private float streamer = 0;
	private int lastClip = 0;
	private float clip_timer = 0;

	public void Start(){ 
		audio = GetComponent<AudioSource> ();
		if (GetComponent<PhotonView> ().isMine) {
			c = Microphone.Start (null, true, 100, freq);
			while(Microphone.GetPosition(null) < 0) {}
		}
	}

	void Update()
	{
		streamer += Time.deltaTime;
		if (GetComponent<PhotonView>().isMine && streamer > .5f) {
			streamer = 0;
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
		/*
		clip_timer += Time.deltaTime;
		if (GetComponent<PhotonView> ().isMine && clip_timer > 5f) {
			// get 10 second clip
			clip_timer = 0;
			int pos = Microphone.GetPosition (null);
			Microphone.End(null);

			// send clip to api
			Debug.Log ("start upload speech");
			WWWForm form = new WWWForm();
			int diff = pos - lastClip;
			float[] samples = new float[diff * c.channels];
			c.GetData (samples, lastClip);
			byte[] ba = ToByteArray (samples);
			lastClip = pos;
			form.AddBinaryData ("clip", ba); // audio file
			WWW www = new WWW ("https://speech.platform.bing.com/recognize", form); // send to arshin
			StartCoroutine (WaitForRequest (www));

			// start new 10 second clip
			c = Microphone.Start (null, true, 100, freq);
			while(Microphone.GetPosition(null) < 0) {}

		}*/
	}

	[PunRPC]
	public void Send(byte[] ba, int chan) {
		float[] f = ToFloatArray(ba);
		audio.clip = AudioClip.Create("clip", f.Length, chan, freq,true,false);
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

	private IEnumerator WaitForRequest(WWW www) {
		yield return www;
		// check for errors
		if (www.error == null) {
			Debug.Log (www.text);
		} else {
			Debug.Log (www.error);
		}
	}

} 