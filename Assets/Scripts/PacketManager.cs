using GoogleVR.HelloVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketManager : MonoBehaviour
{
    public Packet[] packets;
    // Use this for initialization


    
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        CreatePrefab();
    }
    void CreatePrefab()
    {
        foreach (Packet p in packets)
        {
             p.InstantiationTimer -= Time.deltaTime;
            if (p.InstantiationTimer <= 0)
            {
                Instantiate(p);
                p.InstantiationTimer = p.RespawnTimer;
            }
        }
    }


    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.name.Contains("Clone"))
        {
            Destroy(otherObj.gameObject);
            Debug.Log("Packet eliminated");
        }
    }
}
