using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Player") {
            this.transform.rotation = collision.collider.transform.rotation;
        }
    }
}
