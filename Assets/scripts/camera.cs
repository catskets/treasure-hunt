using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerObject; //gives the player a variable

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerObject.position.x, playerObject.position.y, transform.position.z); //constantly takes position of player
    }
}

//basic help from https://www.youtube.com/watch?v=VJjD1Tp1I8U