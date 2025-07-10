using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPadlleController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 3f;
    public Vector2 dir;

    private GameObject ball;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(dir * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-dir * Time.deltaTime);
        }
    }
}
