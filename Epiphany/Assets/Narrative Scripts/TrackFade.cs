using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class TrackFade : MonoBehaviour {

	public int NextScene;
	public float fadeTime = 0.8f;

	// Use this for initialization
	IEnumerator Start () {



	yield return new WaitForSeconds(3);
	gameObject.SetActive(false);

	SceneManager.LoadScene(NextScene);
	}
}
