using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharController : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public float horizontalInput;

    public void Start()
    {
        idleEvent.Invoke();
    }

    public void CharacterMovement()
    {
        //verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        if (horizontalInput < 0 || horizontalInput > 0)
        {
            walkEvent.Invoke();

            if (Input.GetKeyDown(KeyCode.R) == true)
            {
                runEvent.Invoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            jumpEvent.Invoke();
        }


    }
}
