using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;

    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;
    public GameObject ball;

    private void Start()
    {
        LaunchBall();
    }

    public void AddScoreP1()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        LaunchBall();
        
    }

    public void AddScoreP2()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        LaunchBall();
    }

    private void LaunchBall()
    {
        Instantiate(ball, Vector3.zero, Quaternion.identity);
    }
}
