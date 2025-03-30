using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float PH = 7.0f;
    public Coral coral;
    public TextMeshProUGUI PHText;

    public static float GameTimer;

    void Start()
    {
        PH = 7.0f;
        GameTimer = 0f;
    }

    void Update()
    {
        GameTimer += Time.deltaTime;

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
