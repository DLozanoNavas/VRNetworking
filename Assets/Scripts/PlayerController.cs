using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider otherObj)
    {

        if (otherObj.name == "Stage-2")
        {
            FindObjectOfType<AudioManager>().Play("2-Stage");
        }
        else if (otherObj.name == "Stage-3")
        {
            FindObjectOfType<AudioManager>().Play("3-Stage");
        }
        else if(otherObj.name == "Stage-4")
        {
            FindObjectOfType<AudioManager>().Play("4-Stage");
        }
        else if(otherObj.name == "Stage-5")
        {
            FindObjectOfType<AudioManager>().Play("5-Stage");
        }
        else if(otherObj.name == "Stage-6")
        {
            FindObjectOfType<AudioManager>().Play("6-Stage");
        }
        else if(otherObj.name == "Stage-7")
        {
            FindObjectOfType<AudioManager>().Play("7-Stage");
        }
        else if(otherObj.name == "Stage-8")
        {
            FindObjectOfType<AudioManager>().Play("8-Stage");
        }
        else if (otherObj.name == "Stage-9")
        {
            FindObjectOfType<AudioManager>().Play("9-Stage");
        }
        else if (otherObj.name == "Stage-10")
        {
            FindObjectOfType<AudioManager>().Play("10-Stage");
        }
        else if (otherObj.name == "Stage-11")
        {
            FindObjectOfType<AudioManager>().Play("11-Stage");
        }
    } 
}
