using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float moveSpeed;
    public Transform tamanho;


    
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movePlayer = Input.GetAxis("Vertical");
        player.velocity = new Vector2(player.velocity.x, movePlayer * moveSpeed);
    }
}
