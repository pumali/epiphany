using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SongTransition : MonoBehaviour {

	public int destroyedmusiclevel;
	public string LevelName;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	void OnLevelWasLoaded(int level) {
		if (level == destroyedmusiclevel)
			Destroy (gameObject);
	}
}