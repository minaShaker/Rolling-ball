using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after all other items has prccessed in update so the camera will change after 
    // the ball finished moving
	void LateUpdate () {
        transform.position = player.transform.position + offset;

	}
}
