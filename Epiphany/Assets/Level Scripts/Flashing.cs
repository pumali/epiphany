using UnityEngine;
using System.Collections;

public class Flashing : MonoBehaviour {

	public Light flash;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Random.value > 0.9 ) //random flashes
        {
           if ( flash.enabled == true ) //if the light is on...
           {
             flash.enabled = false; //turn it off
           }
           else
           {
             flash.enabled = true; //turn it on
           }
        }
	}
}
