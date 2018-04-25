﻿using System.Collections;
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
        foreach(Packet p in packets)
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
        if (otherObj.CompareTag("Packet"))
        {
            if (otherObj.name != "Packet-1")
            {
                if (otherObj.name != "Packet-2")
                {
                    if (otherObj.name != "Packet-3")
                    {
                        if (otherObj.name != "Packet-4")
                        {
                            if (otherObj.name != "Packet-5")
                            {
                                if (otherObj.name != "Packet-6")
                                {
                                    if (otherObj.name != "Packet-7")
                                    {
                                        if (otherObj.name != "Packet-8")
                                        {
                                            if (otherObj.name != "Packet-9")
                                            {
                                                Destroy(otherObj.gameObject);
                                                Debug.Log("Packet eliminated");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
