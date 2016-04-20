using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour {

	public string PuzzleStatus = "Beginning";
	public AudioSource music;
    public PlayerController player; 
    public string statusPickup = "Beginning";
    public AudioMixerSnapshot[] songSnapshots = new AudioMixerSnapshot[4];

    // Use this for initialization
    void Start () {
	music = GetComponent<AudioSource>();

        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        player = Player.GetComponent<PlayerController>();
        player.isCollecting = statusPickup;
        Debug.Log("understands that isCollecting is statusPickup");
    }

    // Update is called once per frame
    void Update()
    {

        if (PuzzleStatus == "Beginning")
        {
            songSnapshots[0].TransitionTo(0f);
        }

        else if (PuzzleStatus == "Puzzle1")
        {
            songSnapshots[1].TransitionTo(0f);

        }

        else if (PuzzleStatus == "Puzzle2")
        {
            songSnapshots[2].TransitionTo(0f);

        }

        else if (PuzzleStatus == "Puzzle3")
        {
            songSnapshots[3].TransitionTo(0f);
        }

 

         else if (statusPickup == "First")
            {

                PuzzleStatus = "Beginning";
                Debug.Log("plays music again");

            }
        }

    }

