using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

	bool texto;
	public GameObject  dialogo;
	public Dragon dragon;

	void Start () {
		dialogo.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)&& (texto == true)) {
			dialogo.SetActive (true);
		} 
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.Space) || Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.D)) {
			dialogo.SetActive (false);
		}
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Player") {
			dragon.texto2 = true;
			texto = true;
		} 
	}
	void OnTriggerExit2D(Collider2D col){

		if (col.tag == "Player") {
			texto = false;
		} 
	}
}