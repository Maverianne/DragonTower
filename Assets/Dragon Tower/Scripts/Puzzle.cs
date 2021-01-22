using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour {
	bool open;
	private Animator myAnim;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent <Animator> ();
		open = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) && (open == true)) {
			myAnim.SetTrigger ("AbrirEscalera");
			StartCoroutine (SiguienteNivel());
		}

	}
	

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Player") {
			open = true;
		
		} 
}
	IEnumerator SiguienteNivel(){
		yield return new WaitForSeconds (2.0f);
		SceneManager.LoadScene("Atico", LoadSceneMode.Single);
	}
}