using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontPlayer;
    public int pontOpon;
    public Text score;
    public AudioSource somgol;

    private void Start()
    {
        pontPlayer = 0;
        pontOpon = 0;
        score.text = pontPlayer + " x " + pontOpon;
    }

    private void Update()
    {
        
    }

    public void AumentPointPlayer()
    {
        pontPlayer++;
        UpdateTextPoint();

        
        if (pontPlayer == 7)
        {
            FindObjectOfType<NewBehaviourScript>().oponent.transform.localScale = new Vector3(1, 2);
            
        }

        if (pontPlayer == 14)
        {

            FindObjectOfType<NewBehaviourScript>().oponent.transform.localScale = new Vector3(1, 3);

        }

        if (pontPlayer == 20)
        {
            FindAnyObjectByType<Pause>().RestartMatch("SampleScene");
        }

    }
    public void AumentPointOpo()
    {
        pontOpon++;
        UpdateTextPoint();
        
        if (pontOpon == 14)
        {
            FindAnyObjectByType<Moviment>().moveSpeed = 12;
        }

        if (pontOpon == 20)
        {
            FindAnyObjectByType<Pause>().RestartMatch("SampleScene");
        }

    }

    public void UpdateTextPoint()
    {
        score.text = pontPlayer + " x " + pontOpon;
        somgol.Play();
    }
}
