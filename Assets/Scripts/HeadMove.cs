using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    [SerializeField] Vector2 direction;

    private void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        if(xAxis != 0)
        {
            direction = vector2.right * xAxis;
        }
        if (yAxis != 0)
        {
            direction = vector2.up * yAxis;
        }
    }

    void MoveSnake()
    {

    }
}
