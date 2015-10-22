/*
Author: Sri Chatala
File : LevelManager.cs
Created Date: Oct 21,2015
Descriptopn: LevelManager Controller script controlls the level of gameObjects
Laster Updated: Oct 22,2015
*/
using UnityEngine;
using System.Collections;

public class LevelManagerController : MonoBehaviour {

    // Use this for initialization
    public GameObject currentCheckPoint;
    private PlayerController player;

    public int pointOnKill;

	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void PlayerRespond()
    {
        player.transform.position = currentCheckPoint.transform.position;
    }
}
