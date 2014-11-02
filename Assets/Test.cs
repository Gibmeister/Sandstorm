using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

		Vector2 jumpForce = new Vector2 (0, 2);
		DistanceJoint2D distJoint ;
		bool jumping = false;
		Transform shadow;
		static float  jump = 0;
		Vector3 pos;
		// Use this for initialization
		void Start ()
		{
				shadow = GameObject.Find ("Shadow").transform;
				transform.position = new Vector3 (shadow.position.x, shadow.position.y, shadow.position.z ) ; 
		}
		// Update is called once per frame
		void Update ()
			{
				if (Input.GetKey ("space")) {
					Jump ();
				}
				else {
					Fall();
					
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

			
		}
		void Jump(){
		//	jump += .01f;
		transform.position = new Vector3 (transform.position.x + .01f, 
		                                  transform.position.y + .01f,
		                                  transform.position.z - .01f);
		}
		void Fall() {

			if (jump > 0) {
				//jump -= 0.2f;
			
			transform.position = new Vector3 (transform.position.x - .02f, 
			                                  transform.position.y - .02f,
			                                  transform.position.z + .02f);
			}
		}
}
