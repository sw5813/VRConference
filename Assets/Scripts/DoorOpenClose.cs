using UnityEngine;
using System.Collections;

public class DoorOpenClose : MonoBehaviour {
	
	public GameObject LeftDoor;
	public GameObject RightDoor;
	public bool open;
	private float initz;
	
	// Use this for initialization
	void Start () {
		open = false;
		initz = LeftDoor.transform.position.z;
	}
	
	// Update is called once per frame- threshhold for position
	void Update () {
		if (open && LeftDoor.transform.position.z > initz - 7) {
			LeftDoor.transform.Translate(-Vector3.forward * 10 * Time.deltaTime, Space.World);
			RightDoor.transform.Translate(Vector3.forward * 10 * Time.deltaTime, Space.World);
		}
		
		if (!open && LeftDoor.transform.position.z < initz - 0.1) {
			LeftDoor.transform.Translate(Vector3.forward * 10 * Time.deltaTime, Space.World);
			RightDoor.transform.Translate(-Vector3.forward * 10 * Time.deltaTime, Space.World);
		}
	}
	
	void OnTriggerEnter(Collider collide){
		if (collide.gameObject.tag == "Player") {
			open = true;
		}
	}
	
	void OnTriggerExit(Collider collide){
		if (collide.gameObject.tag == "Player") {
			open = false;
		}
	}
}
