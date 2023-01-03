using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moving_blackdots : MonoBehaviour
{
    bool down = true;
    float speed_y = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame0
    void Update()
    {
    if(down){
        transform.position = new Vector3(transform.position.x, Math.Max(transform.position.y - speed_y * Time.deltaTime, 0), transform.position.z);
        speed_y = speed_y*2;
        if(transform.position.y == 0){
            down = false;
        }
    }
    else {
        speed_y = speed_y/2;
        transform.position = new Vector3(transform.position.x, Math.Min(transform.position.y + speed_y * Time.deltaTime, 5), transform.position.z);
        if(transform.position.y == 5){
            down = true;
            speed_y = 0.01f;
        }
    }
}
}
