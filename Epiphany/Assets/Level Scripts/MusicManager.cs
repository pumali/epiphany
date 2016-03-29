using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public string PuzzleStatus = "Beginning";
	AudioSource audio;
	public AudioClip Song1;
	public AudioClip Song2;
	public AudioClip Song3;
	public AudioClip Song4;



	// Use this for initialization
	void Start () {
	audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		if (!audio.isPlaying && PuzzleStatus == "Beginning") {
            audio.clip = Song1;
            audio.Play();
        }

		if (!audio.isPlaying && PuzzleStatus == "Puzzle1") {
            audio.clip = Song2;
            audio.Play();
        }

		if (!audio.isPlaying && PuzzleStatus == "Puzzle2") {
            audio.clip = Song3;
            audio.Play();
        }

		if (!audio.isPlaying && PuzzleStatus == "Puzzle3") {
            audio.clip = Song4;
            audio.Play();
        }
	}
}
