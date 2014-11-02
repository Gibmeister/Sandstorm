using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

		Vector2 jumpForce = new Vector2 (0, 2);
		DistanceJoint2D distJoint ;
		bool jumping = false;
		Transform shadow;
		float  jump = 0;
		// Use this for initialization
		void Start ()
		{
				shadow = GameObject.Find ("Shadow").transform;

				//distJoint = (DistanceJoint2D) gameObject.GetComponent("DistanceJoint2D");
		}
		// Update is called once per frame
		void Update ()
		{
			if (Input.GetKey ("space")) {
				Jump();
			jumping = true;
			} else if (jumping) {
				jump = -1;
			} else {
				jump = 0;
			jumping = false;
				transform.position = new Vector3 (shadow.position.x + jump, 
			                                  shadow.position.y + jump,
			                                  transform.position.z - jump);
			}
		}

		void Jump(){
			jump = 1;
	}
}
