using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

public GameObject Light;
public float fadeTime = 0.8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator OnTriggerEnter(Collider trigger) 
	{
		if (trigger.gameObject.CompareTag("Player") && gameObject.CompareTag("Goal"))
			{
			gameObject.SetActive (false);
			Light.SetActive (false);

			fadeTime = GameObject.Find("Player").GetComponent<Fading>().BeginFade(1);
			yield return new WaitForSeconds(fadeTime);
			SceneManager.LoadScene("Level1");
			}
	
	}
}