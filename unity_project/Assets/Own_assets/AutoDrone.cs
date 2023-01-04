using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Windows.Forms;

public class AutoDrone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject container_ship = GameObject.Find("container_ship");

        if(transform.position.x > container_ship.transform.position.x+3){
            SendKeys.Send("A");
        }
        else if (transform.position.x+3 < container_ship.transform.position.x){
             SendKeys.Send("D");
        }

        if(transform.position.z > container_ship.transform.position.z+5){
            SendKeys.Send("S");
        }
        else if (transform.position.z+5 < container_ship.transform.position.z){
            SendKeys.Send("W");
        }
        
    }
}
