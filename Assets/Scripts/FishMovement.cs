using UnityEngine;

public class FishMovement : MonoBehaviour
{
    private Vector2 direction;
    private float speed;

    public void SetDirection(Vector2 moveDirection, float moveSpeed)
    {
        direction = moveDirection;
        speed = moveSpeed;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>();
                playerRb.AddForce(direction * 200f); 
        }
    }
}
