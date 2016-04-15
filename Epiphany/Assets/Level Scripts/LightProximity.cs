using UnityEngine;
using System.Collections;

public class LightProximity : MonoBehaviour {

	public Transform Cylinder;
	public Transform Player;
	public float distanceLimit = 5.0f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(Cylinder.position, Player.position) < distanceLimit) {
		gameObject.GetComponent<Light>().enabled = true;
		}
		else {
			gameObject.GetComponent<Light>().enabled = false;
		}
	}
}
