using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float oponentSpeed;
    public Rigidbody2D oponent;
    public Transform tamanhoopo;


   
    void Start()
    {
        Move();
        float oponentSpeedy = Random.Range(0, 2);
    }


    void Update()
    {
       
    }

    private void Move()
    {

        float Speedy = Random.Range(0, 2);

        if (Speedy == 0)
        {
            Speedy = -1;
        }
        else
        {
            Speedy = 1;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, oponentSpeed * Speedy);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Topwall")
        {
            oponent.AddForce(Vector2.down * 400);
        }
        if (collision.gameObject.tag == "Bottomwall")
        {
            oponent.AddForce(Vector2.up * 400);
        }
       
    }

    


}
