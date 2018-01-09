using UnityEngine;

using System.Collections;

public class ZombieMovement : MonoBehaviour

{

    public int moveSpeed = 1;  //per second 
    Vector3 computerDirection = Vector3.left;
    Vector3 moveDirection = Vector3.zero;
    Vector3 newPosition = Vector3.zero;
    void Start()
    {

    }
    void Update()
    {
        Vector3 newPosition = computerDirection * (moveSpeed * Time.deltaTime);
        newPosition = transform.position + newPosition;
        //newPosition.x = Mathf.Clamp(newPosition.x, -101, 126);
        transform.position = newPosition;
        if (newPosition.x > 126)
        {
            newPosition.x = 126;
            computerDirection.x *= -1;
        }
        else if (newPosition.x < -101)
        {
            newPosition.x = -101;
            computerDirection.x *= -1;
        }
    }
}