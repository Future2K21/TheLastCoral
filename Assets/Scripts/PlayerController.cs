using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float verticalSpeedMultiplier = 0.6f;
    public float maxOxygen = 100f;
    public float oxygen = 100f;
    public float oxygenDepletionRate = 5f;
    public float oxygenTransferRate = 20f; 
    public KeyCode shareOxygenKey = KeyCode.K; 
    public Image oxygenBar;
    private SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;
    public string horizontalInput;
    public string verticalInput;
    private bool isInAirZone = false;
    float moveX;
    float moveY;
    public bool isPlayerOne;

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
            rb.linearVelocity = new Vector2(moveX, moveY);
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
        if(Input.GetKeyDown(shareOxygenKey))
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
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("AirZone"))
        {
            isInAirZone = false;
        }
    }
}
