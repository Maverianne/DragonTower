using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Animator myAnim;
	public float speed;

	bool moveDer;
	public Transform ColliderTransform; 
	public float jump;
//	private float vida;
	bool enemigo;
    public bool jumping;

    public GameObject inicio;

	void Start () {
//		vida = 5;
		inicio.SetActive(true);
        jumping = false;
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)){

			inicio.SetActive(false);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			myAnim.SetTrigger ("Espada Derecha");

		}

		if (Input.GetKeyDown (KeyCode.Space) && jumping == false) {
			myAnim.SetTrigger ("Salta");	
			transform.Translate (0f, jump, 0f);
            jumping = true;
            StartCoroutine(JumpWait());
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			myAnim.SetTrigger ("Espada Izquierda");

		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			
			transform.Translate (speed, 0f, 0f);
			myAnim.SetBool ("Caminar Der", true);

			} else {
				myAnim.SetBool ("Caminar Der", false); 
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				myAnim.SetBool ("Caminar Izq", true);
				transform.Translate (-speed, 0f, 0f);
		
			} else {
				myAnim.SetBool ("Caminar Izq", false); 
			}
			
		}
    IEnumerator JumpWait()
    {
        yield return new WaitForSeconds(.5f);
        jumping = false;

    }

}

