using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minions : MonoBehaviour {

   
    // Use this for initialization
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) //make random with every click
        {

            for (int i = 1; i <= 5; i++)
            {
                int randomposx = (int)Random.Range(-11.58f, 2f);
                int randomposy = (int)Random.Range(5f, -1f);
                Vector3 paddlePosition = new Vector3(randomposx, randomposy, 0);

                this.transform.position = paddlePosition;
            }
        }
    }
}
