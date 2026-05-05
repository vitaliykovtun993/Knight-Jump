using UnityEngine;

public class platform : MonoBehaviour
{
    public float jumpForce = 10f;
    private Transform cameraTransform;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        // Видаляємо платформу, якщо вона залишилася далеко внизу
        if (cameraTransform.position.y > transform.position.y + 10f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Перевіряємо, чи гравець падає зверху (швидкість по Y <= 0)
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.linearVelocity;
                velocity.y = jumpForce;
                rb.linearVelocity = velocity;
            }
        }
    }
}