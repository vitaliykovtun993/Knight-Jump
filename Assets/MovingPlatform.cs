using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;      // Швидкість руху
    public float distance = 3f;   // Відстань, на яку платформа відходить від центру

    private Vector3 startPosition;

    void Start()
    {
        // Запам'ятовуємо початкову точку, де платформа з'явилася
        startPosition = transform.position;
    }

    void Update()
    {
        // Mathf.PingPong створює нескінченний рух туди-сюди в межах від 0 до distance
        float movement = Mathf.PingPong(Time.time * speed, distance * 2) - distance;

        // Оновлюємо позицію платформи по осі X
        transform.position = new Vector3(startPosition.x + movement, transform.position.y, transform.position.z);
    }
}