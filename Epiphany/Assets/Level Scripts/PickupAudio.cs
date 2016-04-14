using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioClip pickupSound; 
	public AudioClip fastforward; 

	private AudioSource sound; 
	public int ThisClipNumber = 1; 
	public AudioClip[] myAudios = new AudioClip[3];

	void Awake ()
	{ 
		sound = GetComponent<AudioSource>();

	}
		
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
			Debug.Log ("found collider trigger"); 
		{
			if (ThisClipNumber == 1)
				Debug.Log ("found clip number");
			{
				sound.clip = myAudios[0];
				Debug.Log ("found clip from array");
			}
			sound.Play();
			Debug.Log ("played clip"); 

		}
//			sound.clip = pickupSound;
//			sound.Play();  
	}
}