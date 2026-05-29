using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Метод для запуску гри
    public void PlayGame()
    {
        // Завантажуємо ігрову сцену за її назвою. 
        // Переконайся, що назва твоєї ігрової сцени збігається (наприклад, "SampleScene")
        SceneManager.LoadScene("SampleScene");
    }

    // Метод для виходу з гри
    public void QuitGame()
    {
        Debug.Log("Гра закрилася!"); // Це з'явиться в консолі Unity для перевірки
        Application.Quit(); // Працює у зібраному білді гри (.exe або на телефоні)
    }
}