using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioClip pickupSound; 
	public AudioClip fastforward; 

	private AudioSource sound; 

	void Awake ()
	{ 
		sound = GetComponent<AudioSource> (); 
	}

	void Update ()
	{
	 OnTriggerEnter (Collider other) 
		{
			if (other.gameObject.tag == "Player") {
		sound.Play ()  
	}
}
	}
}