using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float PH = 7.0f;
    public Coral coral;
    public TextMeshProUGUI PHText;
    public static bool gameOver;
    [SerializeField]
    public static float GameTimer;

    void Start()
    {
        gameOver = false;
        PH = 7.0f;
        GameTimer = 0f;
    }

    void Update()
    {
        if(gameOver == false)
        {
            GameTimer += Time.deltaTime;
        }

        coral.GameOver();
        UpdatePHUI();
    }


    void UpdatePHUI()
    {
        if (PHText != null)
        {
            PHText.text = "pH: " + PH.ToString("F1"); 
        }
    }
}
