using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class StatusUpdate_IllegalCargo : MonoBehaviour
{
    bool drone_arrived = false;
    bool analyzing = false;
    bool terminated = false;
    DateTime start = DateTime.UtcNow;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("status", "Waiting for drone");
        PlayerPrefs.SetInt("color", 0);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject drone = GameObject.Find("Drone_red");
        GameObject container_ship = GameObject.Find("container_ship");


        if((drone.transform.position.x-container_ship.transform.position.x < 3 & drone.transform.position.x-container_ship.transform.position.x > -3) & (drone.transform.position.z-container_ship.transform.position.z < 3 & drone.transform.position.z-container_ship.transform.position.z > -3) & !drone_arrived){
            PlayerPrefs.SetString("status", "Drone arrived");
            start = DateTime.UtcNow;
            drone_arrived = true;
        }
        else if(drone_arrived & !analyzing & Convert.ToInt32((DateTime.UtcNow - start).TotalSeconds) > 3){
            PlayerPrefs.SetString("status", "Start analyzing");
            start = DateTime.UtcNow;
            analyzing = true;
        }
        else if(analyzing & Convert.ToInt32((DateTime.UtcNow - start).TotalSeconds) > 10 & !terminated){
            PlayerPrefs.SetString("status", "Illegal cargo");
            PlayerPrefs.SetInt("color", 1);
            GameObject.Find("BlackDot").SetActive(false);
            GameObject.Find("BlackDot1").SetActive(false);
            GameObject.Find("BlackDot2").SetActive(false);
            terminated = true;
        }

    }
}
