using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet : MonoBehaviour {

    [Range(0.0f, 50.0f)]
    public float InstantiationTimer = 50.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.CompareTag("Stage"))
        {
            //TODO: Modify behaviour for every Stage on the Packet rail
        }

    }
}
