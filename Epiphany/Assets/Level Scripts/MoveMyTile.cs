using UnityEngine;
using System.Collections;

public class Indiana : MonoBehaviour {

	private GameObject[] Cubex;
	public float Speed;
	private float amountUp =1;
	private bool targetBlocksUp =true;
	//tag name to move public String
	public string tagToMove;
	public Vector3 Up;
	public Vector3 Down;
	public Vector3 Left;
	public Vector3 Right;



 void Start(){

		Cubex = GameObject.FindGameObjectsWithTag (tagToMove);

 }
 
 void Update(){
		//determine up or down, what state are the blocks in. 
		if (targetBlocksUp) {
			if (amountUp < 1.0f) {
				foreach (GameObject cube in Cubex) {
					cube.transform.Translate (Speed * Time.deltaTime * Up);
				}
				amountUp += Speed * Time.deltaTime;
			}
		}

		if (targetBlocksUp == false) {
			if (amountUp > 0.0f) {
				foreach (GameObject cube in Cubex) {
					cube.transform.Translate (Speed * Time.deltaTime * Down);
				}
				amountUp -= Speed * Time.deltaTime;
			}
		}
}


 void OnCollisionEnter (Collision col){
	


		if (col.gameObject.tag == "Player") {
			targetBlocksUp = !targetBlocksUp;
		}
		
		
	}

	
}

