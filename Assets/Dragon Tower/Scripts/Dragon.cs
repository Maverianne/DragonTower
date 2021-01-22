using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {


	bool texto;
	public bool texto2;
	public GameObject  dragon;
	public GameObject  dragon2;
	public GameObject  basura;
	public GameObject creditos;
	bool open;
	bool perder;
	bool ganar;

	void Start () {
		dragon.SetActive (false);
		dragon2.SetActive (false);
		basura.SetActive (false);
		creditos.SetActive (false);
		open = false;
		perder = false;
		ganar = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (texto == true && Input.GetKeyDown (KeyCode.W)) {

			if (texto2 == true) {
				dragon2.SetActive (true);
				open = true;
					
			} else {
				dragon.SetActive (true);
			}
		} 
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.Space) || Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.D)) {
			dragon.SetActive (false);
		}
		if (Input.GetKey (KeyCode.Q) || Input.GetKey (KeyCode.E) ) {
			dragon2.SetActive (false);
		}
		if (Input.GetKeyDown (KeyCode.Q)&& open == true&& perder == false && ganar == false) {
			creditos.SetActive (true);
			ganar = true;
		}
		if(Input.GetKeyDown(KeyCode.E)&& open == true && perder == false && ganar == false) {
			basura.SetActive (true);
			perder = true;
		}
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Player") {
			texto = true;
		} 
	}
	void OnTriggerExit2D(Collider2D col){

		if (col.tag == "Player") {
			texto = false;
		} 
	}

}
