using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour {

	public string PuzzleStatus = "Beginning";
	AudioSource audio;

	public AudioMixerSnapshot tutorialBegin; 
	public AudioMixerSnapshot tutorialPuzzle1;
	public AudioMixerSnapshot tutorialPuzzle2;
	public AudioMixerSnapshot tutorialPuzzle3;


	// Use this for initialization
	void Start () {
	audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {





		if (PuzzleStatus == "Beginning") {
			tutorialBegin.TransitionTo (0.2f);
        }

		if (PuzzleStatus == "Puzzle1") {
			tutorialPuzzle1.TransitionTo (0.2f);

        }

		if (PuzzleStatus == "Puzzle2") {
			tutorialPuzzle2.TransitionTo (0.2f);

        }

		if (PuzzleStatus == "Puzzle3") {
			tutorialPuzzle3.TransitionTo (0.2f);

        }
	}
}
