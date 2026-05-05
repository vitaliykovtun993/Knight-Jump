using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public Transform player;
    public GameObject gameOverPanel; // Перетягни сюди панель
    public TextMeshProUGUI finalScoreDisplay;
    public TextMeshProUGUI highScoreDisplay;
    public ScoreManager scoreManager; // Посилання на скрипт очок

    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver && player.position.y < Camera.main.transform.position.y - 6f)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true); // Вмикаємо панель

        // Зупиняємо час у грі (опціонально, щоб все завмерло)
        Time.timeScale = 0f;

        // Виводимо цифри
        finalScoreDisplay.text = "Результат: " + scoreManager.GetFinalScore();
        highScoreDisplay.text = "Рекорд: " + scoreManager.GetHighScore();
    }

    // Метод для кнопки рестарту
    public void RestartGame()
    {
        Time.timeScale = 1f; // Повертаємо час у норму
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}