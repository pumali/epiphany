using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour{

	public Transform LookAt;

	//state machine
	public string CameraLocation = "OnPlayer";

	public Transform Puzzle1Cam;
	public Transform Puzzle1Sol;
	public Transform Puzzle2aCam;
	public Transform Puzzle2bCam;
	public Transform Puzzle3aCam;
	public Transform Puzzle3bCam;





	//perspective mover
	public float speed1a;
	public float turningRate1a;

	public float speed1b;
	public float turningRate1b;


	public float speed2a;
	public float turningRate2a;

	public float speed2b;
	public float turningRate2b;


	public float speed3a;
	public float turningRate3a;

	public float speed3b;
	public float turningRate3b;

	public Transform target;
    public float distance = 10.0f;
    public float sensitivity;
    private Vector3 offset; 
         
    void Start ()  
    {
    	if (CameraLocation == "OnPlayer")
    	{
    	offset = (transform.position - target.position).normalized * distance;
    	transform.position = target.position + offset;
    	}

        Cursor.visible = false;
    }

    void LateUpdate () 
    {

		//Orbit Camera Controls
		if (CameraLocation == "OnPlayer")
		{
			Quaternion q = Quaternion.AngleAxis(Input.GetAxis ("Mouse X") * sensitivity, Vector3.up);
		    offset = q * offset;
		    transform.position = target.position + offset;
			transform.LookAt(LookAt);
		}

		//Puzzle 1 Camera

		if (CameraLocation == "OnPuzzle1")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle1Cam.position, speed1a * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle1Cam.rotation, turningRate1a * Time.deltaTime);

		}

		//Puzzle 1 Solution

		if (CameraLocation == "OnSolution1")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle1Sol.position, 10 * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle1Sol.rotation, 50 * Time.deltaTime);

		}

		//Puzzle 2a Camera

		if (CameraLocation == "OnPuzzle2a")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle2aCam.position, speed2a * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle2aCam.rotation, turningRate2a * Time.deltaTime);

		}

		//Puzzle 2b Camera

		if (CameraLocation == "OnPuzzle2b")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle2bCam.position, speed2b * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle2bCam.rotation, turningRate2b * Time.deltaTime);

		}

		//Puzzle 3a Camera

		if (CameraLocation == "OnPuzzle3a")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle3aCam.position, speed3a * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle3aCam.rotation, turningRate3a * Time.deltaTime);

		}

		//Puzzle 3b Camera

		if (CameraLocation == "OnPuzzle3b")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle3bCam.position, speed3b * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle3bCam.rotation, turningRate3b * Time.deltaTime);

		}




	}
}