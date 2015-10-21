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
