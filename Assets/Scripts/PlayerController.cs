using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider otherObj)
    {

            if (otherObj.name == "OSILayer2")
            {
                Destroy(otherObj.gameObject);
                FindObjectOfType<AudioManager>().Play("2-Stage");
                Debug.Log("Packet eliminated");
            }


    }
}
