/*
Author: Sri Chatala
File : PlayerCollider.cs
Created Date: Oct 22,2015
Descriptopn: PlayerCollider Controller script controll the Score,Lives, and Sounds of gameObjects
Laster Updated: Oct 22,2015
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

    //Private variables
    private AudioSource[] _gameAuidoSource;
    private AudioSource _coinAudioSource, _deadAudioSource;

    public Text livesLabel;
    public Text scoreLabel;
    public int _score = 0;
    public int lives = 5;
    public Text gameOver;
    public Text finalScore;

    // Use this for initialization
    void Start()
    {
        this._gameAuidoSource = this.GetComponents<AudioSource>();
        this._coinAudioSource = this._gameAuidoSource[1];
        this._deadAudioSource = this._gameAuidoSource[2];
        this._SetLives();
        this.gameOver.enabled = false;
        this.finalScore.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if (otherGameObject.tag == "Coin")
        {
           this._coinAudioSource.Play();
            this._score += 200;
        }
        if (otherGameObject.tag == "Spike")
        {
           this._deadAudioSource.Play();
            this.lives -= 1;
            if (this.lives <= 0)
            {
                this._EndGame();
            }
        }

        this._SetLives();
    }
    private void _SetLives()
    {
        this.livesLabel.text = "Lives:" + this.lives;
        this.scoreLabel.text = "Score:" + this._score;

    }
    private void _EndGame()
    {
        Destroy(gameObject);
        this.livesLabel.enabled = false;
        this.scoreLabel.enabled = false;
        this.gameOver.enabled = true;
        this.finalScore.enabled = true;
        this.finalScore.text = "Final Score:" + this._score;
    }
}
