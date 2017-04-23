using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThing : MonoBehaviour {

    public string color;
    public GameObject obj;
    public Transform spawnPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Not test");
        if (other.tag == color)
        {
            Debug.Log("Test");
            Instantiate(obj, spawnPos);
        }
    }

}
