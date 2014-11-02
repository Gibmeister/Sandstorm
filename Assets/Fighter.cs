using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
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

		if (Input.GetKey(KeyCode.D)) {
			anim.SetInteger("running", 1);
		} else {
			anim.SetInteger("running", 0);
		}
	}	
}
