using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	Animator anim;
	Transform hero;
	AudioSource a;
	GameObject darune;
	// Use this for initialization
	void Start () {
		hero = GameObject.Find ("Hero").transform;
		darune = GameObject.Find ("darune");
		anim = (Animator)GetComponent("Animator");
		a = (AudioSource)GetComponent("AudioSource");
	} 
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			print("here");
			anim.SetInteger("kick", 1);
			a.PlayOneShot(a.clip);
			if (hero.position.y > darune.transform.position.y - 1 && hero.position.y < darune.transform.position.y - 1) {
				Rigidbody2D r = (Rigidbody2D)darune.GetComponent("Rigidbody2D");
				r.AddForce(new Vector2(10,1));
			}

		} else if (Input.GetKeyUp(KeyCode.Return)) {
			anim.SetInteger("kick", 0);
		}

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W)) {
			anim.SetInteger("running", 1);
		} else {
			anim.SetInteger("running", 0);
		}

		transform.position = hero.position;
	}

	public void hitDarune(){
	
		
	}
}



