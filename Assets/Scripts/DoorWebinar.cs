using UnityEngine;
using System.Collections;

public class DoorWebinar : MonoBehaviour {

	public GameObject Door;
	
	public bool open;
	private float initx;
	
	// Use this for initialization
	void Start () {
		open = false;
		initx = Door.transform.position.x;
	}
	
	// Update is called once per frame- threshhold for position
	void Update () {
		if (open && Door.transform.position.x > initx - 30) {
			Door.transform.Translate(Vector3.left * 10 * Time.deltaTime, Space.World);
		}
		
		if (!open && Door.transform.position.x < initx - 0.1) {
			Door.transform.Translate(Vector3.right * 10 * Time.deltaTime, Space.World);
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
