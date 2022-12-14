using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public void Start()
    {
        idleEvent.Invoke();
    }

    public void MoveCharacter()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            jumpEvent.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            walkEvent.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.R) == true)
        {
            runEvent.Invoke();
        }
    }
}
