using UnityEngine;
using System.Collections;

public class FocalPoint : MonoBehaviour {

	public Transform Player;

	public Vector3 pos = new Vector3(0f, 1f, 0f);


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	transform.position = Player.position + pos;
	
	}
}