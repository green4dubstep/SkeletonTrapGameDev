using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    public float moveStep = 1f;  
    private bool isMoving = false;

    public void Move(Vector2 direction)
    {
        if (!isMoving)
        {
            StartCoroutine(MoveCoroutine(direction));
        }
    }

    private IEnumerator MoveCoroutine(Vector2 direction)
    {
        isMoving = true;

        Vector3 newPosition = transform.position + new Vector3(direction.x, direction.y, 0) * moveStep;

        transform.position = newPosition;

        yield return new WaitForSeconds(0.1f);

        isMoving = false;
    }
}
