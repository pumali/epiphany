using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public Color RedColorChange;

	void OnCollisionEnter(Collision trigger) 
	{
		if (trigger.gameObject.CompareTag("Player")){
		gameObject.GetComponent<Renderer> ().material.color = RedColorChange;
		}
	}
}
