using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int curLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} 

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube") {
           SceneManager.LoadScene(curLevel + 1, LoadSceneMode.Single);
        }
    }
}
