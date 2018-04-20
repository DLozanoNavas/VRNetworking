using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketManager : MonoBehaviour
{
    public Packet p1, p2, p3, p4;
    [Range(0.0f, 50.0f)]
    public float t1Respawn;
    [Range(0.0f, 50.0f)]
    public float t2Respawn;
    [Range(0.0f, 50.0f)]
    public float t3Respawn;
    [Range(0.0f, 50.0f)]
    public float t4Respawn;
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
        p1.InstantiationTimer -= Time.deltaTime;
        p2.InstantiationTimer -= Time.deltaTime;
        p3.InstantiationTimer -= Time.deltaTime;
        p4.InstantiationTimer -= Time.deltaTime;
        if (p1.InstantiationTimer <= 0)
        {
            Instantiate(p1);
            p1.InstantiationTimer = t1Respawn;
        }
        if (p2.InstantiationTimer <= 0)
        {
            Instantiate(p2);
            p2.InstantiationTimer = t2Respawn;
        }
        if (p3.InstantiationTimer <= 0)
        {
            Instantiate(p3);
            p3.InstantiationTimer = t3Respawn;
        }
        if (p4.InstantiationTimer <= 0)
        {
            Instantiate(p4);
            p4.InstantiationTimer = t4Respawn;

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
                            Destroy(otherObj.gameObject);
                            Debug.Log("Packet eliminated");
                        }
                    }
                }
            }
        }
    }
}
