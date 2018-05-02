using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet : MonoBehaviour {

    [Range(0.0f, 50.0f)]
    public float InstantiationTimer = 50.0f;
    [Range(0.0f, 50.0f)]
    public float RespawnTimer = 50.0f;
    public ParticleSystem ExplosionEffect;
    // Use this for initialization
    void Awake () {
    }
	
	// Update is called once per frame

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.name.Contains("Packet")) { 
            //TODO: Modify behaviour for every Stage on the Packet rail
            ExplosionEffect.Play();
            Destroy(this);
        }

    }
}
