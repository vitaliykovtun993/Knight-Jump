using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    private float maxAltitude = 0;

    void Update()
    {
        if (player.position.y > maxAltitude)
        {
            maxAltitude = player.position.y;
            scoreText.text = "Score: " + Mathf.RoundToInt(maxAltitude).ToString();
        }
    }

    // Метод для отримання фінальних очок
    public int GetFinalScore() => Mathf.RoundToInt(maxAltitude);

    // Метод для збереження та отримання рекорду
    public int GetHighScore()
    {
        int currentScore = GetFinalScore();
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            return currentScore;
        }
        return highScore;
    }
}