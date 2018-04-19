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
        //switch (otherObj.name)
        //{
        //    case "OSILayer2":
        //        FindObjectOfType<AudioManager>().Play("2-Stage");
        //        break;
        //    case "OSILayer3":
        //        FindObjectOfType<AudioManager>().Play("3-Stage");
        //        break;
        //    case "OSILayer4":
        //        FindObjectOfType<AudioManager>().Play("4-Stage");
        //        break;
        //    case "OSILayer5":
        //        FindObjectOfType<AudioManager>().Play("5-Stage");
        //        break;
        //    case "OSILayer6":
        //        FindObjectOfType<AudioManager>().Play("6-Stage");
        //        break;
        //    case "OSILayer7":
        //        FindObjectOfType<AudioManager>().Play("7-Stage");
        //        break;
        //    case "OSILayer8":
        //        FindObjectOfType<AudioManager>().Play("8-Stage");
        //        break;
        //}

        if (otherObj.name == "OSILayer2")
        {
            FindObjectOfType<AudioManager>().Play("2-Stage");
        }
        else if (otherObj.name == "OSILayer3")
        {
            FindObjectOfType<AudioManager>().Play("3-Stage");
        }
        else if(otherObj.name == "OSILayer4")
        {
            FindObjectOfType<AudioManager>().Play("4-Stage");
        }
        else if(otherObj.name == "OSILayer5")
        {
            FindObjectOfType<AudioManager>().Play("5-Stage");
        }
        else if(otherObj.name == "OSILayer6")
        {
            FindObjectOfType<AudioManager>().Play("6-Stage");
        }
        else if(otherObj.name == "OSILayer7")
        {
            FindObjectOfType<AudioManager>().Play("7-Stage");
        }
        else if(otherObj.name == "OSILayer8")
        {
            FindObjectOfType<AudioManager>().Play("8-Stage");
        }

    } 
}
