using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiWeight : MonoBehaviour {


    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.mass = .01f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
            rb.mass = 1000;
    }
}
