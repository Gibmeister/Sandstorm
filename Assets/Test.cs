using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	float jumpSpeed = 0.15f;
	float fallSpeed = 0.15f;
	float maxJumpHeight = 15;



bool falling = false;
Transform shadow;
Transform oldShadow;
static float  jump = 0;
// Use this for initialization
void Start ()
{
		shadow = GameObject.Find ("Shadow").transform;
		oldShadow = shadow;
}
// Update is called once per frame
void Update ()
{
	if (transform.position.y > oldShadow.transform.position.y) {
		//Updating new position.
		float yPosi = shadow.transform.position.y + jump;
		transform.position = new Vector3 (shadow.transform.position.x, yPosi, transform.position.z);
	} else {
		transform.position = new Vector3 (shadow.transform.position.x, shadow.transform.position.y, transform.position.z);
	}
	if (Input.GetKey ("space")) {
		if(!falling && Mathf.Abs(transform.position.y-oldShadow.position.y)<maxJumpHeight ) {
			Jump();
		} else {
			Fall();
		}
	} else {
		Fall();
	}
	oldShadow = shadow;
}
void Jump(){
	jump += jumpSpeed;
	transform.position = new Vector3 (transform.position.x, 
	                                  shadow.transform.position.y + jump,
	                                  transform.position.z);
}
void Fall() {
	if (transform.position.y > oldShadow.transform.position.y) {
		jump -= fallSpeed;
		falling = true;
		transform.position = new Vector3 (transform.position.x, 
	                         shadow.transform.position.y + jump,
	                         transform.position.z);
	} else if (transform.position.y != oldShadow.transform.position.y) {
		falling = false;
		transform.position = new Vector3 (transform.position.x, 
	                         oldShadow.transform.position.y,
	                         transform.position.z);
	} else {
		falling = false;
	}
}
}
