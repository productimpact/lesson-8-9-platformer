using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private int moveSpeed = 3;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= startPosition.x - 3)
        {
            moveSpeed = Mathf.Abs(moveSpeed); // Change speed to positive
        }
        else if (transform.position.x >= startPosition.x + 3)
        {
            moveSpeed = -Mathf.Abs(moveSpeed); // Change speed to negative
        }

        transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }
}
