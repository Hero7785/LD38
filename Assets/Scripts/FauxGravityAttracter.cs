using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttracter : MonoBehaviour {

    public float gravity;

    public void Attract(Rigidbody rb) {
        Vector3 gravityUp = (rb.position - transform.position).normalized;
        Vector3 localUp = rb.transform.up;

        rb.AddForce(gravityUp * gravity);

        //Debug.Log(rb.name +  ": " + gravityUp * gravity);

        rb.rotation = Quaternion.FromToRotation(localUp, gravityUp) * rb.rotation;
    }
}
