using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

    // Use this for initialization
    FauxGravityAttracter planet;
    Rigidbody body;
	void Awake () {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<FauxGravityAttracter>();
        body = GetComponent<Rigidbody>();

        body.useGravity = false;
        body.constraints = RigidbodyConstraints.FreezeRotation;

	}
	
	// Update is called once per frame
	void Update () {

        planet.Attract(body);
	}
}
