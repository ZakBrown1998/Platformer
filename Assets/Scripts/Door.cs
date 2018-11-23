using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    //Variable to let us add to the score
    //Public so we can drag and drop
    public Score scoreObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreObject.SaveScore();
	}
}
