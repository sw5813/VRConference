using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* Functions for using Microsoft's Project Oxford Speech API */
public class UploadSpeech : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("start upload speech");
		WWW www = new WWW ("https://api.twitter.com/1.1/search/tweets.json");
		StartCoroutine (WaitForRequest (www));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
//	public WWW POST(string url, Dictionary<string,string> post, System.Action onComplete) {
//		WWWForm form = new WWWForm();
//		
//		foreach(KeyValuePair<string,string> post_arg in post) {
//			form.AddField(post_arg.Key, post_arg.Value);
//		}
//		
//		WWW www = new WWW(url, form);
//		
//		StartCoroutine(WaitForRequest(www, onComplete));
//		return www;
//	}
//	
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
