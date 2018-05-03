using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minion : MonoBehaviour {


    // Use this for initialization

    
    public GameObject minion1;
    public GameObject mapEdge1;
    public GameObject mapEdge2;
    Transform spawnPoint;

    float rand1;
    float rand2;

    void Start () {

        for (int i = 0; i <= 5; i++)
        {

            rand1 = Random.Range(mapEdge1.transform.position.x, mapEdge2.transform.position.x);
            Debug.Log(rand1);



            Instantiate(minion1, new Vector3(rand1, -1.86f), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
