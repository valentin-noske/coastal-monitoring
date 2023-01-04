using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moving_blackdots : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame0
    void Update()
    {
    if(transform.position.y == -75){
        transform.position = new Vector3(transform.position.x, -80, transform.position.z);
    }
    else {
        transform.position = new Vector3(transform.position.x, -75, transform.position.z);
    }
}
}
