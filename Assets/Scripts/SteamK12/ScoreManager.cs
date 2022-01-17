using UnityEngine;
using TMPro;

namespace SteamK12.SpaceShooter
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance;
        [SerializeField] int currentScore = 0;
        [SerializeField] int highScore = 0;

        [SerializeField] TextMeshProUGUI currentScoreText;
        [SerializeField] TextMeshProUGUI highScoreText;

        private void Awake()
        {
            Instance = this;
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
}
