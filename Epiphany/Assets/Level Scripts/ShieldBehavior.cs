using UnityEngine;
using System.Collections;

public class ShieldBehavior : MonoBehaviour {

	public GameObject Pickup1;
	public GameObject Pickup2;
	public GameObject Pickup3;
	public PlayerController Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(Collider trigger){
		if (trigger.gameObject.CompareTag("Player")){

			GameObject PlayerBall = GameObject.FindGameObjectWithTag("Player");
			Player = PlayerBall.GetComponent<PlayerController> ();
			Player.isCollecting = "Beginning";

			gameObject.GetComponent<BoxCollider>().enabled = false;
//			yield return new WaitForSeconds(0.5f);
			Pickup1.SetActive(false);
			Pickup2.SetActive(false);
			Pickup3.SetActive(false);
			yield return new WaitForSeconds(2);
			Pickup1.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup2.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup3.SetActive(true);
			gameObject.GetComponent<BoxCollider>().enabled = true;
			yield return new WaitForSeconds(2);


		}
	}
}
