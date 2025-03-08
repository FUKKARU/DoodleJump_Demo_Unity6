using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private float jumpPower;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") && collision.transform.position.y > transform.position.y)
        {
            Rigidbody2D rigidbody = collision.GetComponent<Rigidbody2D>();
            Vector2 velocity = rigidbody.linearVelocity;
            velocity.y = 0;
            rigidbody.linearVelocity = velocity;
            rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
}
