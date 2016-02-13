using UnityEngine;
using System.Collections;

using UnityStandardAssets.Characters.FirstPerson;

/* Sends transform information for individual avatars */
public class PlayerNetworkMover : Photon.MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (photonView.isMine) {
			GetComponent<FirstPersonController>().enabled = true;
			foreach(Camera cam in GetComponentsInChildren<Camera>())
				cam.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
