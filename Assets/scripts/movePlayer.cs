using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movePlayer : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;

    public enum directionState
    {
        up,
        down,
        left,
        right,
        none

    }

    public directionState currentState = directionState.none;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckKey();
        MoveMe();
    }

    void CheckKey() //grabs each piece of code that moves the character depending on the key they press
    {
        if (Input.GetKey(KeyCode.W))
        {
            currentState = directionState.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentState = directionState.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            currentState = directionState.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            currentState = directionState.right;
        }
        else
        {
            currentState = directionState.none;
            Debug.Log("No key pressed");
        }
    }
    void MoveMe() //case switch functions that go for the direction/speed that the player moves
    {
        switch (currentState)
        {
            case directionState.up:
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                Debug.Log("W key pressed");
                break;
            case directionState.down:
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                Debug.Log("S key pressed");
                break;
            case directionState.left:
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                Debug.Log("A key pressed");
                break;
            case directionState.right:
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                Debug.Log("D key pressed");
                break;
            default:
                break;

        }
    }
}