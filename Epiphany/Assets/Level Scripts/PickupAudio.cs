using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioClip pickupSound; 
	public AudioClip fastforward; 
	public string isCollecting = "Beginning";

	private AudioSource sound; 

	public int ThisClipNumber = 1; 
	public AudioClip[] myAudios = new AudioClip[4];

	void Awake ()
	{ 
		sound = GetComponent<AudioSource>();

	}
		
	void OnTriggerEnter (Collider other)
	{
		
		if (other.gameObject.tag == "Player" && isCollecting == "First")
			Debug.Log ("found collider trigger"); 
		{
				sound.clip = myAudios[0];
				Debug.Log ("found clip from array");
			sound.Play();
			Debug.Log ("played clip"); 
		

		 if (other.gameObject.tag == "Player" && isCollecting != "First")
		{
			sound.clip = myAudios [4]; 
			sound.Play(); 
			Debug.Log ("played bad sound"); 
		}
		}
	}
//			sound.clip = pickupSound;
//			sound.Play();  

	}
