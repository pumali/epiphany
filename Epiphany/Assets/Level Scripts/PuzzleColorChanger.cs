using UnityEngine;
using System.Collections;

public class PuzzleColorChanger : MonoBehaviour {
	public PlayerController Player;
	public Color RedColorChange;
	public GameObject[] Puzzle1;


	// Use this for initialization
	void Start () {
		GameObject PlayerBall = GameObject.FindGameObjectWithTag("Player");
		Player = PlayerBall.GetComponent<PlayerController> ();

		Puzzle1 = GameObject.FindGameObjectsWithTag ("Puzzle1Neutrals");
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.isCollecting == "Third") {
		Invoke("ColorChange", 0.1f);
		}
	}

	void ColorChange(){
		if (Player.isCollecting == "Third") {

		foreach(GameObject form in Puzzle1) {
//			yield return new WaitForSeconds(0.1f);
			form.gameObject.GetComponent<Renderer> ().material.color = RedColorChange;

		}
	}
	}
}
