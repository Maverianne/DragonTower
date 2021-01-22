using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murcielago : MonoBehaviour {
	private float x;
	private float y;

	// Use this for initialization
	void Start () {
		x = 0;
		y = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.tag == "Player") {
					transform.Translate (x-.1f, y-.1f, 0f);
			}
		
		} 

}
