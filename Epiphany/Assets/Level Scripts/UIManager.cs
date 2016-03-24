using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {
	public GameObject PausePanel;

	public bool isPaused;

	// Use this for initialization
	void Start () {
		isPaused = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(isPaused)
		{
			PauseGame (true);
		}

		else
		{
			PauseGame (false);
		}

		if (Input.GetButtonDown("Cancel")) 
		{
			SwitchPause ();
		}
	}

	void PauseGame (bool state)  //freezes time, sets panel active
	{     

		if (state) 
		{
			Time.timeScale = 0.0f;
		}

		else 
		{
			Time.timeScale= 1.0f;
		}
		PausePanel.SetActive(state);
	}

	public void SwitchPause()  //changes the pause value
	{
		if (isPaused)
		{
			isPaused = false;
		}

		else
		{
			isPaused = true;
		}
	}

}