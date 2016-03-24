using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

public GameObject Light;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider trigger) 
	{
		if (trigger.gameObject.CompareTag("Player"))
			{
			gameObject.SetActive (false);
			Light.SetActive (false);
			}
	
	}
}