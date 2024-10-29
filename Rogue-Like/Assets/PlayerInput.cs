using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public DiscreteMovement movementScript;  // Reference to DiscreteMovement script

    void Update()
    {
        // Capture the WASD or Arrow keys input
        float moveX = Input.GetAxisRaw("Horizontal");  // -1 for left, 1 for right
        float moveY = Input.GetAxisRaw("Vertical");    // -1 for down, 1 for up

        // If there is input, pass it to the movement script
        if (moveX != 0 || moveY != 0)
        {
            movementScript.Move(new Vector2(moveX, moveY));
        }
    }
}
