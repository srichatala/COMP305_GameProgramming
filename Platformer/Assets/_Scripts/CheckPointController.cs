/*
Author: Sri Chatala
File : CheckPointController.cs
Created Date: Oct 21,2015
Descriptopn: Checkpoint Controller script controll the boundaries of gameObjects
Laster Updated: Oct 21,2015
*/
using UnityEngine;
using System.Collections;

public class CheckPointController : MonoBehaviour {

    public LevelManagerController levelManager;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManagerController>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckPoint = gameObject;
        }
    }
}
