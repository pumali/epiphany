using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public BridgeStates BridgeStatus;
	public CameraController MainCamera;
	public Transform cam;
	public float speed; 
	public float JumpHeight;
	private Rigidbody rb;
	public float SpeedBoost;
	public float SpeedTimer;
	public float CorruptionTimer;
	public float CorruptionRespawner;
	//Color Triggers
	public Color CorruptionColorChange;
	public Color CorruptionColorReturn;
	public Color JumpColorChange;
	public Color JumpColorReturn;
	public Color BoostColorChange;
	public Color BoostColorReturn;
	public Color CollectibleChange;
	public Color CollectibleReturn;
	public string isCollecting = "Beginning";



	void Start (){
	 	rb = GetComponent<Rigidbody>();
	 }

	void FixedUpdate (){
	//Movement
 		Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
 		if(inputDirection.sqrMagnitude > 1){
    			inputDirection = inputDirection.normalized;
			}
 
 	//Takes the camera's facing into account
 		Vector3 newRight = Vector3.Cross(Vector3.up, cam.forward);
 		Vector3 newForward = Vector3.Cross(newRight, Vector3.up);
 		Vector3 movement = (newRight * inputDirection.x) + (newForward * inputDirection.y);
 
 		rb.AddForce(movement * speed);
 	}

	IEnumerator OnTriggerEnter(Collider trigger) {

	//Collectibles 1-3 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp1")){
			trigger.gameObject.SetActive (false);
			isCollecting = "First";
		}
		if (isCollecting == "First" && trigger.gameObject.CompareTag("PickUp2")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Second";
		}

		if (isCollecting == "Second" && trigger.gameObject.CompareTag("PickUp3")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Third";

			yield return new WaitForSeconds(0.5f);
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnSolution1";
			yield return new WaitForSeconds(1.0f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge1");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState1 = true;
		}

//test area!!!!!!

		//Collectibles 4-6 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp4")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Fourth";
		}
		if (isCollecting == "Fourth" && trigger.gameObject.CompareTag("PickUp5")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Fifth";
		}

		if (isCollecting == "Fifth" && trigger.gameObject.CompareTag("PickUp6")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Sixth";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution2";
//			yield return new WaitForSeconds(1.0f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge2");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState2 = true;
		}


		//Collectibles 7-9 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp7")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Seventh";
		}
		if (isCollecting == "Seventh" && trigger.gameObject.CompareTag("PickUp8")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Eighth";
		}

		if (isCollecting == "Eighth" && trigger.gameObject.CompareTag("PickUp9")){
			trigger.gameObject.SetActive (false);
			isCollecting = "Ninth";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution2";
//			yield return new WaitForSeconds(1.0f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge3");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState3 = true;
		}



//end of test area!!!

	
//Set Camera Perspective Trigger
		if (trigger.gameObject.CompareTag("Puzzle1")){
			if (isCollecting != "Second"){
				GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
				MainCamera = Camera.GetComponent<CameraController> ();
				MainCamera.CameraLocation = "OnPuzzle1";
			}
		}
    }

//Revert to Orbiting Camera
	void OnTriggerExit (Collider camtrigger)
	{
		if (camtrigger.gameObject.CompareTag("Puzzle1"))
			{
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
			}
	}


    //Corruption Cubes
	IEnumerator OnCollisionEnter(Collision cube) {

		if (cube.gameObject.tag == "CorruptionCube")
		{
		//Color Change
		cube.gameObject.GetComponent<Renderer> ().material.color = CorruptionColorChange;
		//Disappear
		yield return new WaitForSeconds(CorruptionTimer);
		cube.gameObject.SetActive(false);
		yield return new WaitForSeconds(CorruptionRespawner);
		//Color Return
		cube.gameObject.GetComponent<Renderer> ().material.color = CorruptionColorReturn;
		//Reappear
		cube.gameObject.SetActive(true);
		//Grow
		}

	//Jump Cubes
		if (cube.gameObject.CompareTag("JumpCube")){
			//Color Change
			cube.gameObject.GetComponent<Renderer>().material.color = JumpColorChange;
			//Jump
			rb.AddForce(0, JumpHeight, 0);
			//Color Return
			yield return new WaitForSeconds(0.25f);
			cube.gameObject.GetComponent<Renderer>().material.color = JumpColorReturn;
		}

	//Boost Cubes
		if (cube.gameObject.CompareTag("BoostCube")){
			//Color Change
			cube.gameObject.GetComponent<Renderer>().material.color = BoostColorChange;
			//Boost
			speed = SpeedBoost;
			Invoke("ResetSpeed", SpeedTimer);
			//Color Return
			yield return new WaitForSeconds(0.25f);
			cube.gameObject.GetComponent<Renderer>().material.color = BoostColorReturn;
		}
	}
	void ResetSpeed(){
		speed = 10f;
	}
}