using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioSource pickup; 

 IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {

			//Debug.Log ("about to play pickup " + other.gameObject.tag);
			GetComponent<AudioSource>().Play(); 
		}
	}
}