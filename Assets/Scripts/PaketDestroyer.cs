﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaketDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.name.Contains("badPackage") && otherObj.name.Contains("Clone"))
        {
            //TODO: Modify behaviour for every Stage on the Packet rail
            GetComponent<Animator>().Play("DestroyPacket");
        }

    }
}
