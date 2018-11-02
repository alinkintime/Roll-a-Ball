using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //store a public referance to the Player game object
    public GameObject player;

    //create a vecotr3 offset from the player (a distance ot place the camera from the player)
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        //create an offset by subtracting the cameras position form the players position
        offset = transform.position - player.transform.position;

	}
	
    // After the 'update()' loop runs. and just before each frame is rendered. 
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;

    }
}
