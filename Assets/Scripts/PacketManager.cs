using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketManager : MonoBehaviour {
    public GameObject packet;
    public float InstantiationTimer = 1.0f;
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
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(packet);
            InstantiationTimer = 1.0f;
        }

    }
    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.CompareTag("Packet"))
        {
            if (otherObj.name != "FacebookPacket")
            {
                Destroy(otherObj.gameObject);
                Debug.Log("Packet eliminated");
            }
        }

    }
}
