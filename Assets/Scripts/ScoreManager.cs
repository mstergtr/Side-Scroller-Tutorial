using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int currentScore = 0;
    public int highScore = 0;

    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        currentScoreText.SetText("SCORE: " + currentScore);
        highScoreText.SetText("HIGH SCORE: " + highScore);
    }

    public void IncreseScore (int scoreAmount)
    {
        currentScore += scoreAmount;
        currentScoreText.SetText("SCORE: " + currentScore);
        if (highScore < currentScore)
        {
            PlayerPrefs.SetInt("highScore", currentScore);
        }
    }
}
