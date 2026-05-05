using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab; // Сюди перетягни префаб платформи
    public Transform playerTransform; // Сюди перетягни гравця

    public int numberOfPlatforms = 10; // Скільки платформ тримати попереду
    public float levelWidth = 5f;      // Ширина розкиду (залежить від вікна гри)
    public float minY = 1.5f;          // Мін. відстань між платформами
    public float maxY = 3.5f;          // Макс. відстань

    private float lastSpawnY = -2f;    // Позиція останньої створеної платформи

    void Start()
    {
        // Створюємо початкові платформи
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            SpawnPlatform();
        }
    }

    void Update()
    {
        // Якщо гравець піднявся близько до останньої платформи — створюємо нову
        if (playerTransform.position.y > lastSpawnY - 10f)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        lastSpawnY += Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3();

        // Додаємо transform.position.x, щоб платформи спавнились навколо об'єкта-генератора
        spawnPosition.x = transform.position.x + Random.Range(-levelWidth, levelWidth);
        spawnPosition.y = lastSpawnY;

        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}