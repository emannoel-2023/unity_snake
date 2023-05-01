using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    [SerializeField] Vector2 direction;
    [SerializeField] List<Transform> snakePiecesBody;
    [SerializeField] Transform body;


    private void Start()
    {
        snakePiecesBody = new List<Transform>();
        snakePiecesBody.Add(transform);
    }
    private void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        if (xAxis != 0)
        {
            direction = Vector2.right * xAxis;
        }
        if (yAxis != 0)
        {
            direction = Vector2.up * yAxis;
        }
    }
    private void FixedUpdate()
    {
        for (int i = snakePiecesBody.Count -1 ; i > 0; i--)
        {
            snakePiecesBody[i].position = snakePiecesBody[i - 1].position;
        }
        MoveSnake();
    }
    void MoveSnake()
    {
        float roundPosiX = Mathf.Round(transform.position.x);
        float roundPosiY = Mathf.Round(transform.position.y);

        transform.position = new Vector2(roundPosiX + direction.x, roundPosiY + direction.y);
    }
    void GrowingSnake()
    {
        Transform SpawnBody = Instantiate(body, snakePiecesBody[snakePiecesBody.Count -1].position, Quaternion.identity);
        snakePiecesBody.Add(SpawnBody);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Food":
                GrowingSnake();
                break;
        }
    }
}
