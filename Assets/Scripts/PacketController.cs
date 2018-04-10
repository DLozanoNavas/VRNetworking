using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketController : MonoBehaviour {

    public GameObject packet;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < 5; i++)
        {
            Instantiate(packet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CreatePrefab(OSI7Collision);
    }
    public float InstantiationTimer = 0.5f;
    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(packet);
            InstantiationTimer = 0.5f;
        }
        
    }

}
