using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public Color RedColorChange;
	public float ColorChangeTimer = 4;
	public Color RedColorReturn;


	IEnumerator OnCollisionEnter(Collision trigger) 
	{
		if (trigger.gameObject.CompareTag("Player")){
		gameObject.GetComponent<Renderer> ().material.color = RedColorChange;
		yield return new WaitForSeconds(ColorChangeTimer);
		gameObject.GetComponent<Renderer> ().material.color = RedColorReturn;

		}
	}
}
