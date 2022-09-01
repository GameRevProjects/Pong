using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1;
    public GameManager gameManager;
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if(isPlayer1) gameManager.AddScoreP2();
            else gameManager.AddScoreP1();
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }
}
