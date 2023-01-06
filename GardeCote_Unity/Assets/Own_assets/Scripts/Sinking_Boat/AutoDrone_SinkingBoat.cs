using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Windows.Forms;

public class AutoDrone_SinkingBoat : MonoBehaviour
{
    bool drone_arrived = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject container_ship = GameObject.Find("container_ship");

        if(PlayerPrefs.GetString("status") == "Drone arrived"){
            drone_arrived = true;
        }

        if(!drone_arrived){
        if(transform.position.x > container_ship.transform.position.x+120){
            SendKeys.Send("A");
        }
        else if (transform.position.x+120 < container_ship.transform.position.x){
             SendKeys.Send("D");
        }

        if(transform.position.z > container_ship.transform.position.z+5){
            SendKeys.Send("S");
        }
        else if (transform.position.z+5 < container_ship.transform.position.z){
            SendKeys.Send("W");
        }
        }
        else{
            if(transform.position.x > container_ship.transform.position.x-120){
            SendKeys.Send("A");
        }
        if(transform.position.z > container_ship.transform.position.z+3){
            SendKeys.Send("S");
        }
        else if (transform.position.z+3 < container_ship.transform.position.z){
            SendKeys.Send("W");
        }
        }
        
    }
}
