﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReboteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 295 && gameObject.transform.position.y <= -10 && gameObject.transform.position.z >= 181){
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
        
    }
}
