using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;
    public Text ScoreText; 

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            IncreaseScore(1);
        }
    }
    
    void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + score;
        }
    }
}


    

