using UnityEngine;
using System.Collections;

public class SpriteCastsShadows : MonoBehaviour {



	// Use this for initialization
	void Start () {
		renderer.castShadows = true;
		renderer.receiveShadows = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
