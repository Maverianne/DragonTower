using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rata : MonoBehaviour {


	private float x;

	// Use this for initialization
	void Start () {
		x = 0;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D col){

		if (col.tag == "Player") {
			transform.Translate (x - .1f, 0f, 0f);
		}
	} 
}
