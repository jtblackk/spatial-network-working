﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketCollider : MonoBehaviour
{
    public bool received;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c) {
        if (c.transform.gameObject.tag == "PortBox") {
            received = true;
        }
    }
}
