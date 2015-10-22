/*
Author: Sri Chatala
File : EnemyController.cs
Created Date: Oct 21,2015
Descriptopn: Enemy Controller script to kill the player gameObjects
Laster Updated: Oct 22,2015
*/
using UnityEngine;
using System.Collections;

public class KillPlayerController : MonoBehaviour {

    // Use this for initialization
    public LevelManagerController levelManager;
	void Start () {
        levelManager = FindObjectOfType<LevelManagerController>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.PlayerRespond();
        }
    }
}
