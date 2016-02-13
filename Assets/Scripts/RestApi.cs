//using UnityEngine;
//using System.Collections;
//using System.Net;
//using System.IO;
//
///* REST API for making server calls */
//public class RestApi: MonoBehaviour {
//	private string results;
//
//	public String Results {
//		get {
//			return results;
//		}
//	}
//
//	public WWW GET(string url, System.Action onComplete ) {
//		
//		WWW www = new WWW (url);
//		StartCoroutine (WaitForRequest (www, onComplete));
//		return www;
//	}
//
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
//	private IEnumerator WaitForRequest(WWW www, System.Action onComplete) {
//		yield return www;
//		// check for errors
//		if (www.error == null) {
//			results = www.text;
//			onComplete();
//		} else {
//			Debug.Log (www.error);
//		}
//	}
//}