using UnityEngine;
using System.Collections;

public class BridgeStates : MonoBehaviour {

//States
	public bool BridgeState1 = false;
	public bool BridgeState2 = false;
	public bool BridgeState3 = false;

//	public int BridgeState= 0;
	public GameObject[] Bridge1;


	// Use this for initialization
	void Start () {

		Bridge1 = GameObject.FindGameObjectsWithTag ("Bridge1");
			foreach(GameObject form in Bridge1) {
			form.GetComponent<Renderer> ().enabled = false;
			form.GetComponent<Collider> ().enabled = false;
			}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BridgeState1 == true){
//		if (BridgeState <= 2 && BridgeState >= 0){
			foreach(GameObject form in Bridge1) {
//				yield return new WaitForSeconds(0.01f);
    			form.GetComponent<Renderer> ().enabled = true;
				form.GetComponent<Collider> ().enabled = true;
			}
		}
	}
}
