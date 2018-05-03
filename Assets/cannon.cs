using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    float left = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //to make with arrow to move to the left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            left -= .2f;
            this.transform.position = new Vector3(left, transform.position.y, transform.position.z);
        }

        // to make with arrow to move to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            left += .2f;
            this.transform.position = new Vector3(left,transform.position.y, transform.position.z);
        }
	}
}
