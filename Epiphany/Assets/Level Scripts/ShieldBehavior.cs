using UnityEngine;
using System.Collections;

public class ShieldBehavior : MonoBehaviour {

	public GameObject Pickup1;
	public GameObject Pickup2;
	public GameObject Pickup3;
	public GameObject Pickup4;
	public GameObject Pickup5;
	public GameObject Pickup6;
	public GameObject Pickup7;
	public GameObject Pickup8;
	public GameObject Pickup9;
	public PlayerController Player;
	public BridgeStates BridgeStatus1;
	public BridgeStates BridgeStatus2;
	public BridgeStates BridgeStatus3;


	// Use this for initialization
	void Start () {
		GameObject PlayerBall = GameObject.FindGameObjectWithTag("Player");
		Player = PlayerBall.GetComponent<PlayerController> ();

		GameObject BridgeCubes1 = GameObject.FindGameObjectWithTag("Bridge1");
		BridgeStatus1 = BridgeCubes1.GetComponent<BridgeStates> ();

		GameObject BridgeCubes2 = GameObject.FindGameObjectWithTag("Bridge2");
		BridgeStatus2 = BridgeCubes2.GetComponent<BridgeStates> ();

		GameObject BridgeCubes3 = GameObject.FindGameObjectWithTag("Bridge3");
		BridgeStatus3 = BridgeCubes3.GetComponent<BridgeStates> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(Collider trigger){
		if (trigger.gameObject.CompareTag("Player") && BridgeStatus1.BridgeState1 == false && gameObject.CompareTag("Shield1")){

			
			Player.isCollecting = "Beginning";

			gameObject.GetComponent<BoxCollider>().enabled = false;
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



		if (trigger.gameObject.CompareTag("Player") && BridgeStatus1.BridgeState1 == true && gameObject.CompareTag("Shield2")){

			
			Player.isCollecting = "Beginning";

			gameObject.GetComponent<BoxCollider>().enabled = false;
			Pickup4.SetActive(false);
			Pickup5.SetActive(false);
			Pickup6.SetActive(false);
			yield return new WaitForSeconds(2);
			Pickup4.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup5.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup6.SetActive(true);
			gameObject.GetComponent<BoxCollider>().enabled = true;
			yield return new WaitForSeconds(2);
	

		}


		if (trigger.gameObject.CompareTag("Player") && BridgeStatus2.BridgeState2 == true && gameObject.CompareTag("Shield3")){

			
			Player.isCollecting = "Beginning";

			gameObject.GetComponent<BoxCollider>().enabled = false;
			Pickup7.SetActive(false);
			Pickup8.SetActive(false);
			Pickup9.SetActive(false);
			yield return new WaitForSeconds(2);
			Pickup7.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup8.SetActive(true);
			yield return new WaitForSeconds(2);
			Pickup9.SetActive(true);
			gameObject.GetComponent<BoxCollider>().enabled = true;
			yield return new WaitForSeconds(2);
	

		}

	}
}
