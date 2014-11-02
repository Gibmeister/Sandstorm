using UnityEngine;
using System.Collections;

public class shadowMover : MonoBehaviour {

	static float horizontalSpeed = 10;
	Vector2 jumpForce = new Vector2(0,10);
	Vector2 moveForce = new Vector2(horizontalSpeed,0);
	static float yUpperBound = 20;
	static float yLowerBound = 3;
	static float xLeftBound = -24;
	static float xRightBound = 19;
	static bool jumping = false;

	static Vector3 minimsize = new Vector3(0.3f,0.3f,0.3f); 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			rigidbody2D.AddForce(moveForce);
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody2D.AddForce(-moveForce);
		}
		if (Input.GetKey (KeyCode.W)) {
			rigidbody2D.AddForce(jumpForce);
		}
		if (Input.GetKey (KeyCode.S)) {
			rigidbody2D.AddForce(-jumpForce);
		}
		
		if((transform.position.x <= xLeftBound) && rigidbody2D.velocity.x < 0){
			rigidbody2D.velocity = new Vector2((rigidbody2D.velocity.x * -0.1f), rigidbody2D.velocity.y);
		}
		if((transform.position.x >= xRightBound) && rigidbody2D.velocity.x > 0){
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * -0.1f, rigidbody2D.velocity.y);
		}
		
		if((transform.position.y <= yLowerBound) && rigidbody2D.velocity.y < 0){
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -0.1f);
		}
		if((transform.position.y >= yUpperBound) && rigidbody2D.velocity.y > 0){
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * -0.1f);
		}
	}
}
