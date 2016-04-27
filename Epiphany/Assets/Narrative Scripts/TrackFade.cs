using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class TrackFade : MonoBehaviour {
	public AudioSource audioSource;

	public int NextScene;
	public float fadeTime = 0.8f;
	public AudioClip Narrative;
	public float NarrativeTimer;
	public AudioClip Tape;


	// Use this for initialization
	IEnumerator Start () {
	audioSource = GetComponent<AudioSource>();
	
	yield return new WaitForSeconds(1.5f);

	audioSource.PlayOneShot(Narrative, 0.7f);

	yield return new WaitForSeconds(NarrativeTimer);

	audioSource.PlayOneShot(Tape, 0.7f);


	yield return new WaitForSeconds(3);
	gameObject.SetActive(false);

	SceneManager.LoadScene(NextScene);
	}
}
