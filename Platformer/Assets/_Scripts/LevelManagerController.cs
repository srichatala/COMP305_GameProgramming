using UnityEngine;
using System.Collections;

public class LevelManagerController : MonoBehaviour {

    // Use this for initialization
    public GameObject currentCheckPoint;
    private PlayerController player;

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
