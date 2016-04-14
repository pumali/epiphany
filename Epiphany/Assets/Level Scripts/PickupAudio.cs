using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioClip pickupSound; 
	public AudioClip fastforward; 

	private AudioSource sound; 

	public AudioClip[] myAudios = new AudioClip[3];
	public PlayerController myplr;

	void Awake ()
	{ 
		sound = GetComponent<AudioSource>();
		myplr = FindObjectOfType<PlayerController>();

	}

	void Update ()
	{



	}


	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag =="Player"  ) {
				Debug.Log ("collider entred");

			if (myplr.isCollecting == "First") {
				//play sound 1 	
				sound.clip = myAudios[0];
				sound.Play ();
				Debug.Log ("you played thiss sound from here");

			}
//			sound.clip = pickupSound;
//			sound.Play();  
		}
	}
}