using UnityEngine;

public class SpecialBlock : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D col;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        // If it touches Player, do nothing
        if (collision.gameObject.CompareTag("Player"))
            return;

        // Otherwise, disable physics
        if (rb != null) rb.simulated = false;
        if (col != null) col.enabled = false;
    }
}
