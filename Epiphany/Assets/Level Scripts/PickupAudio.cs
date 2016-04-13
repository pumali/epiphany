using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupAudio : MonoBehaviour {

	public AudioClip pickupGood; 
	public AudioClip pickupBad; 

    IEnumerator OnTriggerEnter(Collider Pickup1) 
	{
		IEnumerator Start;	 
		{
			AudioSource audio = GetComponent<AudioSource>();

			audio.Play();
			yield return new WaitForSeconds (audio.clip.length);
			audio.clip = pickupGood; 

		}
	}
}