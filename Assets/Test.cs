using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	float jumpSpeed = 0.15f;
	float fallSpeed = 0.15f;
	float maxJumpHeight = 15;



Vector2 jumpForce = new Vector2 (0, 2);
DistanceJoint2D distJoint ;
bool falling = false;
Transform shadow;
Transform oldShadow;
static float  jump = 0;
Vector3 pos;
// Use this for initialization
void Start ()
{
		shadow = GameObject.Find ("Shadow").transform;
		oldShadow = shadow;
		//transform.position = new Vector3 (shadow.position.x, shadow.position.y, shadow.position.z ) ; 
}
// Update is called once per frame
void Update ()
{
	if (Input.GetKey ("space")) {
			print("gonna jump");
			print("a: " + (Mathf.Abs(transform.position.y-oldShadow.position.y)<maxJumpHeight));
			if(!falling && Mathf.Abs(transform.position.y-oldShadow.position.y)<maxJumpHeight) {
			Jump();
		} else {
			Fall();
		}
	} else {
		Fall();
	}

		if (transform.position.y > oldShadow.transform.position.y) {
						//Updating new position.
						float yPosi = shadow.transform.position.y + Mathf.Abs (transform.position.y - oldShadow.transform.position.y);
						transform.position = new Vector3 (shadow.transform.position.x, yPosi, transform.position.z);
		
		} else {
			transform.position = new Vector3 (shadow.transform.position.x, shadow.transform.position.y, transform.position.z);
					

				}
				
					//transform.position = new Vector3 (shadow.position.x + jump, 
  				    //                              shadow.position.y + jump,
  				    //                              transform.position.z - jump);


	if (transform.position.y > shadow.position.y) {
				
	}


//				transform.position = new Vector3 (shadow.position.x, shadow.position.y, shadow.position.z);
//				pos = new Vector3 (shadow.position.x + jump, 
//			                    shadow.position.y + jump,
//			                    transform.position.z - jump);
//				if (shadow.position.x < pos.x) {
//						transform.position = new Vector3 (shadow.position.x + jump, 
//				                                  shadow.position.y + jump,
//				                                  transform.position.z - jump);
//				}

		oldShadow = shadow;
	}
	void Jump(){
	//	jump += .01f;
		transform.position = new Vector3 (transform.position.x, 
		                                  transform.position.y + jumpSpeed,
		                                  transform.position.z);
	}
	void Fall() {
		if (transform.position.y > oldShadow.transform.position.y) {
			//jump -= 0.2f;
			falling = true;
			transform.position = new Vector3 (transform.position.x, 
		                         transform.position.y - fallSpeed,
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
