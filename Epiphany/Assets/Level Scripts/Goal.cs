using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

public GameObject PickUpParticleEffect;

public GameObject Light;
public float fadeTime = 0.8f;

	void OnTriggerEnter(Collider trigger) 
	{
		if (trigger.gameObject.CompareTag("Player") && gameObject.CompareTag("Goal"))
			{
			gameObject.SetActive (false);
			Light.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			fadeTime = GameObject.Find("Player").GetComponent<Fading>().BeginFade(1);
			Invoke ("SceneChange", fadeTime);
			}
	
	}

	void SceneChange(){
			SceneManager.LoadScene(1);
	}

}