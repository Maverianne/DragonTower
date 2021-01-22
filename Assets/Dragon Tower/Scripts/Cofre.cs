using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cofre : MonoBehaviour {
	private Animator myAnim;
	bool open;
	// Use this for initialization
	void Start () {
		myAnim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W) && (open == true)) {
			myAnim.SetTrigger ("Abrir");
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
		SceneManager.LoadScene("Regreso Cafe", LoadSceneMode.Single);
	}
}
