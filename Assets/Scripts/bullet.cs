using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private cannon mycannon;
    private Vector3 distance;
    public GameObject Bullet = null;
    public float bulletSpeed = 500f;
    public Rigidbody rb;
    
    // Use this for initialization
    void Start()
    {
        //to lock bullet with cannon
        mycannon = GameObject.FindObjectOfType<cannon>();

        distance = this.transform.position - mycannon.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //locking bullet with cannon
        if(!Input.GetMouseButtonDown(0))
        {
            this.transform.position = mycannon.transform.position + distance;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(Bullet, transform.position + (transform.forward * 2), transform.rotation) as GameObject;
            
            rb.AddForce(transform.forward * bulletSpeed);
        }
        
    }
}
