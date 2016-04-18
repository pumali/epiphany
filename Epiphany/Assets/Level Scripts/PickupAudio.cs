﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {


	public string pickUpState = "Beginning";

	private AudioSource sound; 

	public int ThisClipNumber = 1; 
	public AudioClip[] myAudios = new AudioClip[4];

	void Awake ()
	{ 
		sound = GetComponent<AudioSource>();

	}
		
	//reference to playercontroller script to check PickUp state
	GameObject Player = GameObject.FindGameObjectWithTag("Player");
	//pickUpState = Player.GetComponent<PlayerController>();

	void OnTriggerEnter (Collider other)
	{
		

		if (other.gameObject.tag == "Player" && pickUpState == "First")
			Debug.Log ("found collider trigger"); 
		{
				sound.clip = myAudios[0];
				Debug.Log ("found clip from array");
				sound.Play();
				Debug.Log ("played clip"); 
		

			if (other.gameObject.tag == "Player" && pickUpState != "First")
		{

		}
		}
	}
//			sound.clip = pickupSound;
//			sound.Play();  

}
