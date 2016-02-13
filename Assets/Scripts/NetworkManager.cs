using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* Manages multiplayer network via PUN */
public class NetworkManager : MonoBehaviour {
	
	GameObject player;

	// Use this for initialization
	void Start () {
		PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Display connection status on screen for debugging
	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}

	// When connected, join ConfLobby by default
	void OnJoinedLobby() {
		RoomOptions ro = new RoomOptions () {isVisible = true, maxPlayers = 10};
		PhotonNetwork.JoinOrCreateRoom ("ConfLobby", ro, TypedLobby.Default);
	}

	// When first connected to a room (e.g. ConfLobby), spawn avatar at random location 
	void OnJoinedRoom() {
		float x = Random.Range (-2.0f, 2.0f);
		float z = Random.Range (-2.0f, 2.0f);

		player = PhotonNetwork.Instantiate ("FPSController", 
		                                    new Vector3(x,0.5f,z),
		                                    Quaternion.Euler(0,0,0),
		                                    0);
	}
}
