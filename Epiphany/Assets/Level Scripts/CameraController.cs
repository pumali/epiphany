using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour{

	public Transform LookAt;

	//state machine
	public string CameraLocation = "OnPlayer";

	public Transform Puzzle1Cam;
	public Transform Puzzle1Sol;
	//perspective mover
	public float speed;

	//rotator
	public float turningRate;

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
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle1Cam.position, speed * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle1Cam.rotation, turningRate * Time.deltaTime);

		}

		//Puzzle 1 Solution

		if (CameraLocation == "OnSolution1")
		{
		//direction
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, Puzzle1Sol.position, 10 * Time.deltaTime);

		//rotation
			transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Puzzle1Sol.rotation, 50 * Time.deltaTime);

		}


	}
}