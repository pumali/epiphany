using UnityEngine;
using System.Collections;

public class BridgeStates : MonoBehaviour {

//States
	public bool BridgeState1 = false;
	public bool BridgeState2 = false;
	public bool BridgeState3 = false;

	public GameObject[] Bridge1;
	public GameObject[] Bridge2;
	public GameObject[] Bridge3;

	// Use this for initialization
	void Start () {

		Bridge1 = GameObject.FindGameObjectsWithTag ("Bridge1");
		Debug.Log ("found tag"); 
			foreach(GameObject form in Bridge1) {
			form.GetComponent<Renderer> ().enabled = false;
			Debug.Log ("render enabled"); 
			form.GetComponent<Collider> ().enabled = false;
			Debug.Log ("collider enabled"); 
			}

		Bridge2 = GameObject.FindGameObjectsWithTag ("Bridge2");
			foreach(GameObject form in Bridge2) {
			form.GetComponent<Renderer> ().enabled = false;
			form.GetComponent<Collider> ().enabled = false;
			}

		Bridge3 = GameObject.FindGameObjectsWithTag ("Bridge3");
			foreach(GameObject form in Bridge3) {
			form.GetComponent<Renderer> ().enabled = false;
			form.GetComponent<Collider> ().enabled = false;
			}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BridgeState1 == true){
			foreach(GameObject form in Bridge1) {
//					yield return new WaitForSeconds(0.01f);
    				form.GetComponent<Renderer> ().enabled = true;
					form.GetComponent<Collider> ().enabled = true;
			}
		}
		

		if (BridgeState2 == true){
			foreach(GameObject form in Bridge2) {
//					yield return new WaitForSeconds(0.01f);
    				form.GetComponent<Renderer> ().enabled = true;
					form.GetComponent<Collider> ().enabled = true;
			}
		}

		if (BridgeState3 == true){
			foreach(GameObject form in Bridge3) {
//					yield return new WaitForSeconds(0.01f);
    				form.GetComponent<Renderer> ().enabled = true;
					form.GetComponent<Collider> ().enabled = true;
			}
		}
	}
}
