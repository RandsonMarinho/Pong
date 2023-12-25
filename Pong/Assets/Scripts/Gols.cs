using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gols : MonoBehaviour
{
    public bool golPlayer;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(golPlayer == true)
        {
            FindObjectOfType<GameManager>().AumentPointOpo();
            FindObjectOfType<Ball>().ball.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().AumentPointPlayer();
            FindObjectOfType<Ball>().ball.transform.position = Vector2.zero;
        }
    }
}
