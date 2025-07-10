using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5f;

    public string movementAxisName = "Vertical";

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;


    void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveController.Instance.colorEnemy;
    }

    void Update()
    {
        float moveIput = Input.GetAxis(movementAxisName);

        Vector3 newPosition = transform.position + Vector3.up * moveIput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}
