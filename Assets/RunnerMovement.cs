using UnityEngine;
using System.Collections;

public class RunnerMovement : MonoBehaviour {

	Vector3 right;
	Vector3 left;
	Vector3 up;
	Vector3 down;
	Vector3 jump;
	float speed = 5;
	float jumpSpeed = 20;
	bool isJumping = false;
	bool facingLeft = false;

	static float tau = 0.02f;

	// Use this for initialization
	void Start () {
		right = new Vector3(speed,0,0);
		left = new Vector3(-speed,0,0);
		up = new Vector3(0,0,speed);
		down = new Vector3(0,0,-speed);
		jump = new Vector3(0,jumpSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D)){
			if (!facingLeft) {
				transform.transform.Rotate(new Vector3(0,180,0));
				facingLeft = true;
			}
			Move (right);
		}
		if (Input.GetKey(KeyCode.A)) {

			if (facingLeft) {
				facingLeft = false;
				transform.transform.Rotate(new Vector3(0,180,0));
			}
			Move(left);
		}
		if (Input.GetKey(KeyCode.W)) {
			Move(up);
		}
		if (Input.GetKey(KeyCode.S)) {
			Move(down);
		}

		if (Input.GetKey(KeyCode.Space)) {
			Move(jump);

		}

	}

	void Move(Vector3 direction) {
		rigidbody.AddForce(direction);
	}
}

