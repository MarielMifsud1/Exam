using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    float y = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.RightArrow)) // to move with right arrow to the right
        {
            y += .2f;
            this.transform.position = new Vector3(y, transform.position.y, transform.position.z);
        }

        if(Input.GetKey(KeyCode.LeftArrow)) // to move with left arrow to the left
        {
            y -= .2f;
            this.transform.position = new Vector3(y, transform.position.y, transform.position.z);
        }

	}
}
