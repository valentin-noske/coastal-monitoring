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
    if(transform.position.y > -80){
        transform.position -= transform.up * 0.05f;
    }
    else {
        transform.position += transform.up * 0.05f;
    }
}
}
