using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float PH = 7.0f;
    public Coral coral;
    public TextMeshProUGUI PHText;

    void Start()
    {
        PH = 7.0f;
    }

    void Update()
    {
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
