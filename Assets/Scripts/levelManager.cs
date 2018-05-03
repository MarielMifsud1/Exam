using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	// Use this for initialization

    public void startGame(string levelname) // to change scenes write name in unity
    {
        print("Name of scene is: " + levelname);
        SceneManager.LoadScene(levelname);
    }
    public void quitGame() // to quit game
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
