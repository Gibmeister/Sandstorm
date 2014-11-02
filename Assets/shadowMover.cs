using UnityEngine;
using System.Collections;

public class shadowMover : MonoBehaviour {

	static float horizontalSpeed = 10;
	Vector2 jumpForce = new Vector2(0,10);
	Vector2 moveForce = new Vector2(horizontalSpeed,0);
	static bool jumping = false;

	static float yUpperBound;
	static float yLowerBound;
	static float xUpperBound;
	static float xLowerBound;

	static Vector3 minimsize = new Vector3(0.3f,0.3f,0.3f); 
	// Use this for initialization
	void Start () {

		//TODO make sure shadow is on floor.

		GameObject road =  GameObject.Find ("Road");
		yUpperBound = road.transform.position.y + road.renderer.bounds.size.y / 2;
		yLowerBound = road.transform.position.y -road.renderer.bounds.size.y / 2;
		xUpperBound = road.transform.position.x + road.renderer.bounds.size.x / 2;
		xLowerBound = road.transform.position.x - road.renderer.bounds.size.x / 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D) && !(transform.position.x >= xUpperBound)) {
			transform.position = new Vector3 (transform.position.x+0.1f, transform.position.y, transform.position.z );
		}
		if (Input.GetKey (KeyCode.A)&& !(transform.position.x <= xLowerBound)) {
			transform.position = new Vector3 (transform.position.x-0.1f, transform.position.y, transform.position.z );
		}
		if (Input.GetKey (KeyCode.W)&& !(transform.position.y >= yUpperBound)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y+0.1f, transform.position.z ); 
		}
		if (Input.GetKey (KeyCode.S) && !(transform.position.y <= yLowerBound)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y-0.1f, transform.position.z ); 
		}
	}
}
