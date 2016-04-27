using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuoteTransition : MonoBehaviour {

	public int NextLevel;
	public float fadeTime = 0.8f;


	void Awake(){
		Invoke ("FadeOut", 10f);

		Invoke ("SceneChange", 13f);


	}

	void FadeOut(){
		fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
	}

	void SceneChange(){
		SceneManager.LoadScene(NextLevel);
	}

}