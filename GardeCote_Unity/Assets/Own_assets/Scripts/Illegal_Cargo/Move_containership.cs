using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_containership : MonoBehaviour
{
    float speed_x = 0.5f;
    float speed_y = 0;
    float speed_z = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed_x * Time.deltaTime, transform.position.y + speed_y * Time.deltaTime, transform.position.z + speed_z * Time.deltaTime);
    }
}
