using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float maxSpeed = 3f;

    public float verticalSpeedMultiplier = 0.6f;
    public float maxOxygen = 100f;
    public float oxygen = 100f;
    public float oxygenDepletionRate = 5f;
    public float oxygenTransferRate = 20f; 
    public KeyCode shareOxygenKey = KeyCode.K;
    public float oxygenShareDistance = 3;
    public Image oxygenBar;
    private SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;
    public string horizontalInput;
    public string verticalInput;
    private bool isInAirZone = false;
    float moveX;
    float moveY;
    public bool isPlayerOne;

    public PlayerController otherPlayer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        HandleMovement();
        HandleOxygen();
        FlipSprite();
    }

    void HandleMovement()
    {
        if(oxygen > 0)
        {
            moveX = Input.GetAxis(horizontalInput) * moveSpeed;
            moveY = Input.GetAxis(verticalInput) * moveSpeed * verticalSpeedMultiplier;
            //rb.linearVelocity = new Vector2(moveX, moveY);
            rb.AddForce(new Vector2(moveX, moveY), ForceMode2D.Force);

        }
        if (rb.linearVelocity.magnitude > maxSpeed) { 
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
        if (transform.position.x > 9) {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            transform.position = new Vector2(9f, transform.position.y);
        }
        if (transform.position.x < -9) {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            transform.position = new Vector2(-9f, transform.position.y);
        }

    }
    void FlipSprite()
    {
        if(moveX > 0)
        {
            spriteRenderer.flipX = false;

        }
        if (moveX < 0)
        {
            spriteRenderer.flipX = true;

        }
    }

    void HandleOxygen()
    {
        if (!isInAirZone)
        {
            oxygen -= oxygenDepletionRate * Time.deltaTime;
            oxygen = Mathf.Clamp(oxygen, 0, maxOxygen);
        }
        else
        {
            oxygen += oxygenDepletionRate * 2 * Time.deltaTime;
            oxygen = Mathf.Clamp(oxygen, 0, maxOxygen);
        }

        UpdateOxygenUI();
    }

    public void ShareOxygen()
    {
        if(Input.GetButtonDown("Fire2") && Vector2.Distance(transform.position, otherPlayer.transform.position) < oxygenShareDistance)
        {
            Debug.Log("Shared O2");
            UpdateOxygenUI();
        }
    }

    void UpdateOxygenUI()
    {
        if (oxygenBar != null)
        {
            oxygenBar.fillAmount = oxygen / maxOxygen;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("AirZone"))
        {
            isInAirZone = true;
        }
        if (other.CompareTag("Bubble"))
        {
            Bubble b = other.GetComponent<Bubble>();
            b.Vacuum = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("AirZone"))
        {
            isInAirZone = false;
        }
    }
}
