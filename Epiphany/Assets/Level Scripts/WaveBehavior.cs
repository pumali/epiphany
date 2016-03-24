using UnityEngine;
using System.Collections;

public class WaveBehavior : MonoBehaviour {

	Vector3 startPosition;
	public float amplitude;
	public float interval;
	public float frequency;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;	
	}

	// Update is called once per frame
	void FixedUpdate () {
		float x = startPosition.x;
		float y = amplitude * Mathf.Sin (Time.timeSinceLevelLoad * frequency + Mathf.PI/(interval)) + startPosition.y;
		float z = startPosition.z;

		transform.position = new Vector3 (x, y, z);

	}
}