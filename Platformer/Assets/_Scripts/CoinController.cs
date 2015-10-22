/*
Author: Sri Chatala
File : CoinController.cs
Created Date: Oct 21,2015
Descriptopn: Coin Controller script generate the coins to add score of gameObjects
Laster Updated: Oct 22,2015
*/
using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D others)
    {
        if (others.GetComponent<PlayerController>() == null)
            return;
        Destroy(gameObject);
    }
}
