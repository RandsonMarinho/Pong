using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speedBall;
    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;
    public Rigidbody2D ball;
    public  AudioSource som;
    private float aceleration;

    void Start()
    {
        MoveBall();
    }

    
    void Update()
    {
        
    }

    public void MoveBall()
    {
        float SpeedX = Random.Range(0, 2);
        float SpeedY = Random.Range(0, 2);
        if (SpeedX == 0)
        {
            SpeedX = -1;
        }
        else
        {
            SpeedX = 1;
        }
       
        if (SpeedY == 0)
        {
            SpeedY = -1;
        }
        else
        {
            SpeedY = 1;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(speedBall * SpeedX, speedBall * SpeedY);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        som.Play();
        
    }
  
    
}
