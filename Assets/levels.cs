using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour {

    public void startBtn(string loadName)
    {
        print("Name of scene: " + loadName);
        SceneManager.LoadScene(loadName);
       
    }
    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
