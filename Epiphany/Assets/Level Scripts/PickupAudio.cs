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

    IEnumerator OnTriggerEnter(Collider Pickup1)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp2)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp3)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp4)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp5)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp6)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp7)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp8)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }

    IEnumerator OnTriggerEnter(Collider PickUp9)
    {
        IEnumerator Start;
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = pickupGood;

        }
    }
}