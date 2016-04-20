using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject PickUpParticleEffect;
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

	//music variables
	public string isCollecting = "Beginning";
	public MusicManager Music;
	public AudioSource sound;
	public AudioClip[] variousClips = new AudioClip[3];


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

	void OnTriggerEnter(Collider trigger) {

	//Collectibles 1-3 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp1")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "First";
			Debug.Log("understands that pickup is First");

			//collectible audio sound
			sound.clip = variousClips[0];
			sound.PlayOneShot(variousClips[0]);
			Debug.Log("plays first pickup sound");
		}
		if (isCollecting == "First" && trigger.gameObject.CompareTag("PickUp2")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Second";
			Debug.Log("understands that pickup is First");

			//collectible audio sound
			sound.clip = variousClips[1];
			sound.PlayOneShot(variousClips[1]);
			Debug.Log("plays second pickup sound");
		}

		if (isCollecting == "Second" && trigger.gameObject.CompareTag("PickUp3")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Third";
//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution1";
//			yield return new WaitForSeconds(1.0f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge1");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState1 = true;

		//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Player");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle1";
			Debug.Log ("knows Puzzle 1 is complete"); 

		}
		//Collectibles 4-6 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp4")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Fourth";
		}
		if (isCollecting == "Fourth" && trigger.gameObject.CompareTag("PickUp5")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Fifth";
		}

		if (isCollecting == "Fifth" && trigger.gameObject.CompareTag("PickUp6")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Sixth";
			//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Player");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle2";

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
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Seventh";
		}
		if (isCollecting == "Seventh" && trigger.gameObject.CompareTag("PickUp8")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Eighth";
		}

		if (isCollecting == "Eighth" && trigger.gameObject.CompareTag("PickUp9")){
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Ninth";

			//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Player");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle3";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution2";
//			yield return new WaitForSeconds(1.0f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge3");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState3 = true;
		}
	}
//Set Camera Perspective Trigger
	void OnTriggerStay (Collider trigger){
	//Puzzle 1 Perspective
		if (trigger.gameObject.CompareTag("Puzzle1")){
				GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
				MainCamera = Camera.GetComponent<CameraController> ();
				MainCamera.CameraLocation = "OnPuzzle1";
		}
	//Puzzle 2a Perspective
		if (trigger.gameObject.CompareTag("Puzzle2a")){
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPuzzle2a";
		}

	//Puzzle 2b Perspective
		if (trigger.gameObject.CompareTag("Puzzle2b")){
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPuzzle2b";
		}

	//Puzzle 3a Perspective
		if (trigger.gameObject.CompareTag("Puzzle3a")){
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPuzzle3a";
		}

	//Puzzle 3b Perspective
		if (trigger.gameObject.CompareTag("Puzzle3b")){
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPuzzle3b";
		}
    }

//Revert to Orbiting Camera
	void OnTriggerExit (Collider camtrigger)
	{
		//exiting Puzzle 1 trigger zone
		if (camtrigger.gameObject.CompareTag ("Puzzle1")) {
			GameObject Camera = GameObject.FindGameObjectWithTag ("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
		}

		//exiting Puzzle 2a trigger zone
		if (camtrigger.gameObject.CompareTag ("Puzzle2a")) {


			GameObject Camera = GameObject.FindGameObjectWithTag ("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
		}

		//exiting Puzzle 2b trigger zone
		if (camtrigger.gameObject.CompareTag ("Puzzle2b")) {

			GameObject Camera = GameObject.FindGameObjectWithTag ("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
		}


		//exiting Puzzle 3a trigger zone
		if (camtrigger.gameObject.CompareTag ("Puzzle3a")) {


			GameObject Camera = GameObject.FindGameObjectWithTag ("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
		}

		//exiting Puzzle 3b trigger zone
		if (camtrigger.gameObject.CompareTag ("Puzzle3b")) {

			GameObject Camera = GameObject.FindGameObjectWithTag ("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
		}

		// coding for returning to music after sound effect
		if (camtrigger.gameObject.CompareTag ("PickUp1")) {
			GameObject Player = GameObject.FindGameObjectWithTag ("Player");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Beginning";
			Debug.Log ("Returns to music from PC script"); 
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