/*
Author: Sri Chatala
File : EnemyController.cs
Created Date: Oct 20,2015
Descriptopn: Checkpoint Controller script controll the boundaries of gameObjects
Laster Updated: Oct 21,2015
*/

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed = 100f;

    public bool moveRight;

    public Transform boundryCheck;
    public float boundryCheckRadius;
    public LayerMask whatIsBoundry;
    private bool boundry;

    //private bool notAtEdge;
    //public Transform edgeCheck;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        boundry = Physics2D.OverlapCircle(boundryCheck.position, boundryCheckRadius, whatIsBoundry);
     //   notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, boundryCheckRadius, whatIsBoundry);

        if (boundry)
            moveRight = !moveRight;
        if (!moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
