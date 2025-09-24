using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;

    public int scoreValue = 10; // Points awarded for defeating this enemy
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb.position.y < -50f)
        {
            float randomX = Random.Range(-10f, 10f);
            float randomY = Random.Range(5f, 10f);
            rb.position = new Vector2(randomX, randomY);

            // RESET physics so it doesn't accumulate falling speed
            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;
            scoreValue += 10; // Increase score value each time the enemy respawns
            Debug.Log("Enemy respawned! New score value: " + scoreValue);
        }
    }
}
