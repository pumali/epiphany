using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
	public Color Cryptic1ColorChange;
	public Color Cryptic1ColorReturn;
	public Color Cryptic2ColorChange;
	public Color Cryptic2ColorReturn;
	public Color Cryptic3ColorChange;
	public Color Cryptic3ColorReturn;
	public Color Cryptic4ColorChange;
	public Color Cryptic4ColorReturn;

	public string isCollecting = "Beginning";
	public MusicManager Music;
	public AudioSource audioSource;

	//audio
	public AudioClip PickUp1;
	public AudioClip PickUp2;
	public AudioClip PickUp3;
	public AudioClip FastForward;


	public float fadeTime = 0.4f;


	public string isCryptic = "Start";

	void Start (){
	 	rb = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();

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
			audioSource.PlayOneShot(PickUp1, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "First";
		}
		if (isCollecting == "First" && trigger.gameObject.CompareTag("PickUp2")){
			audioSource.PlayOneShot(PickUp2, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Second";
		}

		if (isCollecting == "Second" && trigger.gameObject.CompareTag("PickUp3")){
			audioSource.PlayOneShot(PickUp3, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Third";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution1";
//			yield return new WaitForSeconds(1.0f);

		//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Mixer");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle1";

			yield return new WaitForSeconds(0.5f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge1");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState1 = true;

			audioSource.PlayOneShot(FastForward, 0.7f);

		}
		//Collectibles 4-6 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp4")){
			audioSource.PlayOneShot(PickUp1, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Fourth";
		}
		if (isCollecting == "Fourth" && trigger.gameObject.CompareTag("PickUp5")){
			audioSource.PlayOneShot(PickUp2, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Fifth";
		}

		if (isCollecting == "Fifth" && trigger.gameObject.CompareTag("PickUp6")){
			audioSource.PlayOneShot(PickUp3, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Sixth";

			//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Mixer");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle2";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution2";
//			yield return new WaitForSeconds(1.0f);

			yield return new WaitForSeconds(0.5f);
			audioSource.PlayOneShot(FastForward, 0.7f);

			GameObject BridgeCubes = GameObject.FindGameObjectWithTag("Bridge2");
			BridgeStatus = BridgeCubes.GetComponent<BridgeStates> ();
			BridgeStatus.BridgeState2 = true;

	
		}
		//Collectibles 7-9 Correct Sequence
		if (isCollecting == "Beginning" && trigger.gameObject.CompareTag("PickUp7")){
			audioSource.PlayOneShot(PickUp1, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Seventh";
		}
		if (isCollecting == "Seventh" && trigger.gameObject.CompareTag("PickUp8")){
			audioSource.PlayOneShot(PickUp2, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Eighth";
		}

		if (isCollecting == "Eighth" && trigger.gameObject.CompareTag("PickUp9")){
			audioSource.PlayOneShot(PickUp3, 0.7f);
			trigger.gameObject.SetActive (false);
			Instantiate(PickUpParticleEffect, gameObject.transform.position, Quaternion.LookRotation(Vector3.up));
			isCollecting = "Ninth";

			//reference to music manager to change the song
			GameObject Player = GameObject.FindGameObjectWithTag("Mixer");
			Music = Player.GetComponent<MusicManager> ();
			Music.PuzzleStatus = "Puzzle3";

//			yield return new WaitForSeconds(0.5f);
//			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
//			MainCamera = Camera.GetComponent<CameraController> ();
//			MainCamera.CameraLocation = "OnSolution2";
//			yield return new WaitForSeconds(1.0f);

			yield return new WaitForSeconds(0.5f);
			audioSource.PlayOneShot(FastForward, 0.7f);


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
		if (camtrigger.gameObject.CompareTag("Puzzle1")){
			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
			}

		//exiting Puzzle 2a trigger zone
		if (camtrigger.gameObject.CompareTag("Puzzle2a")){


			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
			}

		//exiting Puzzle 2b trigger zone
		if (camtrigger.gameObject.CompareTag("Puzzle2b")){

			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
			}


		//exiting Puzzle 3a trigger zone
		if (camtrigger.gameObject.CompareTag("Puzzle3a")){


			GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
			MainCamera = Camera.GetComponent<CameraController> ();
			MainCamera.CameraLocation = "OnPlayer";
			}

		//exiting Puzzle 3b trigger zone
		if (camtrigger.gameObject.CompareTag("Puzzle3b")){

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

	//Cryptic Puzzle
		if (cube.gameObject.tag == "Cryptic1"){
			//Color Change
		cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic1ColorChange;
		}

		if (cube.gameObject.tag == "Cryptic2"){
			//Color Change
		cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic2ColorChange;
		}

		if (cube.gameObject.tag == "Cryptic3"){
			//Color Change
		cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic3ColorChange;
		}

		if (cube.gameObject.tag == "Cryptic4"){
			//Color Change
		cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic4ColorChange;
		}

		//Cryptic Puzzle Sequence
		if (cube.gameObject.CompareTag("Cryptic1")){
			isCryptic = "First";
		}

		if (cube.gameObject.CompareTag("Cryptic2") && isCryptic == "First"){
			isCryptic = "Second";
		}

		if (cube.gameObject.CompareTag("Cryptic3") && isCryptic == "Second"){
			isCryptic = "Third";
		}

		if (cube.gameObject.CompareTag("Cryptic4") && isCryptic == "Third"){
			isCryptic = "Fourth";
			fadeTime = GameObject.Find("Player").GetComponent<Fading>().BeginFade(1);
			Invoke ("SceneChange", fadeTime);
		}
	}

	void SceneChange(){
		SceneManager.LoadScene("Final");
	}

	void OnCollisionExit(Collision cube) {
		if (cube.gameObject.tag == "Cryptic1"){
			cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic1ColorReturn;
		}
		if (cube.gameObject.tag == "Cryptic2"){
			cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic2ColorReturn;
		}
		if (cube.gameObject.tag == "Cryptic3"){
			cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic3ColorReturn;
		}
		if (cube.gameObject.tag == "Cryptic4"){
			cube.gameObject.GetComponent<Renderer> ().material.color = Cryptic4ColorReturn;
		}
	}
	void ResetSpeed(){
		speed = 10f;
	}
}