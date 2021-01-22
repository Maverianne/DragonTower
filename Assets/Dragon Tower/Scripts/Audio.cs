using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public AudioSource GolpeAudio;
	public AudioSource CaminarAudio;
	public AudioSource JumpAudio;
	public AudioSource CaerAudio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlayPunch()
	{
		GolpeAudio.Play ();
	}
	public void PlayWalk()
	{
		CaminarAudio.Play ();
	}
	public void PlayJump()
	{
		JumpAudio.Play ();
	}
	public void PlayCaer()
	{
		CaerAudio.Play ();
	}
}
