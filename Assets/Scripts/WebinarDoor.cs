using UnityEngine;
using System.Collections;

public class WebinarDoor : MonoBehaviour {

	public bool open;
	private float initx;
	
	// Use this for initialization
	void Start () {
		open = false;
		initx = transform.position.x;
	}
	
	// Update is called once per frame- threshhold for position
	void Update () {
		Debug.Log (initx);
		if (open && transform.position.x > initx - 30) {
			transform.Translate(Vector3.left * 10 * Time.deltaTime, Space.World);
		}
		
		if (!open && transform.position.x < initx - 0.1) {
			transform.Translate(Vector3.right * 10 * Time.deltaTime, Space.World);
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
