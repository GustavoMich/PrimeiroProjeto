using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour
{

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;




    public float speed = 5f;


    void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveController.Instance.colorEnemy;
    }



    void Update()
    {
        float moveInput = Input.GetAxis("Vertical2");

        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}
