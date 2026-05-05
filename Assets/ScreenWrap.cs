using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private float screenWidth;

    void Start()
    {
        // ¬ираховуЇмо меж≥ екрана по ширин≥ в одиниц€х Unity
        // 0.5f - це центр, Camera.main.aspect враховуЇ сп≥вв≥дношенн€ стор≥н
        float screenHeight = Camera.main.orthographicSize * 2f;
        screenWidth = screenHeight * Camera.main.aspect;
    }

    void Update()
    {
        float halfWidth = screenWidth / 2f;

        // ѕерев≥р€Їмо, чи вийшов гравець за праву межу
        if (transform.position.x > halfWidth)
        {
            transform.position = new Vector3(-halfWidth, transform.position.y, transform.position.z);
        }
        // ѕерев≥р€Їмо, чи вийшов гравець за л≥ву межу
        else if (transform.position.x < -halfWidth)
        {
            transform.position = new Vector3(halfWidth, transform.position.y, transform.position.z);
        }
    }
}