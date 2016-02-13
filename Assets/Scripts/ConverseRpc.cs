using UnityEngine;

/* Makes RPC calls to send audio to intended listeners */
public class ConverseRpc : MonoBehaviour {
	
	[PunRPC]
	void Speak()
	{
		Debug.Log("Speak");
		
		AudioSource aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start("Built-in Microphone", true, 10, 44100);
		aud.Play();
	}
}
