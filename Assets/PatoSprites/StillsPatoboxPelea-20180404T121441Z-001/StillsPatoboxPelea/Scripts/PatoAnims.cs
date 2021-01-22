using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoAnims : MonoBehaviour {
	private Animator myAnim;

	public AudioSource punchAudio;
	public AudioSource dodgeAudio;
	public AudioSource swing1Audio;
	public AudioSource swing2Audio;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X) && Input.GetKey (KeyCode.UpArrow)) {
			//Animacion Punch Up R
			myAnim.SetTrigger("PunchUpR");
		}
		if (Input.GetKeyDown (KeyCode.Z) && Input.GetKey (KeyCode.UpArrow)) {
			//Animacion Punch Up R
			myAnim.SetTrigger("PunchUpL");
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			myAnim.SetBool ("DodgeR", true);
		} else {
			myAnim.SetBool ("DodgeR", false);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			myAnim.SetBool ("DodgeL", true);
		} else {
			myAnim.SetBool ("DodgeL", false);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			//Animacion Punch Up R
			myAnim.SetTrigger("PunchL");
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//Animacion Punch Up R
			myAnim.SetTrigger("PunchR");
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			myAnim.SetBool ("Block", true);
		} else {
			myAnim.SetBool ("Block", false);
		}
	}
	public void PlayPunch()
	{
		punchAudio.Play ();
	}
	public void PlayDodge()
	{
		dodgeAudio.Play ();
	}
	public void PlaySwing1()
	{
		swing1Audio.Play ();
	}
	public void PlaySwing2()
	{
		swing2Audio.Play();
	}
}
