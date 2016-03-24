using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrackFade : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {

	yield return new WaitForSeconds(3);
	gameObject.SetActive(false);
	yield return new WaitForSeconds(2);


	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
