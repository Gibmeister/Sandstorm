using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	Animator anim;
	Transform hero;
	// Use this for initialization
	void Start () {
		hero = GameObject.Find ("Hero").transform;
		anim = (Animator)GetComponent("Animator");
	} 
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift)) {
			print("here");
			anim.SetInteger("kick", 1);
		} else if (Input.GetKeyUp(KeyCode.LeftShift)) {
			anim.SetInteger("kick", 0);
		}

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W)) {
			anim.SetInteger("running", 1);
		} else {
			anim.SetInteger("running", 0);
		}

		transform.position = hero.position;
	}



}
