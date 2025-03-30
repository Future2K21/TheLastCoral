using UnityEngine;
using UnityEngine.SceneManagement;

public class Coral : MonoBehaviour
{
    public float coralHealth = 30f;
    public string GameOverScene;
    public float maxHealth = 30f;
    private SpriteRenderer spriteRenderer;
    public Color coralColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.PH > 6.5f && GameManager.PH < 7.5 && coralHealth < 30f)
        {
            coralHealth += Time.deltaTime;
        }
        if (GameManager.PH > 6.5f && coralHealth < 30f)
        {
            coralHealth -= Time.deltaTime;
        }
        else
        {
            coralHealth -= Time.deltaTime;
        }

            float t = coralHealth / maxHealth;
            spriteRenderer.color = Color.Lerp(Color.white, coralColor, t);


    }

    public void GameOver()
    {
        if (coralHealth < 0f)
        {
            GameManager.gameOver = true;
            SceneManager.LoadScene(GameOverScene);
        }
    }
}
