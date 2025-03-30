using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SceneStart : MonoBehaviour
{
    public TMP_Text HighScoreText;
    public TMP_Text TimerText;
    public string GameScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        TimerText.text = "Timer: " + Mathf.RoundToInt(GameManager.GameTimer);
        HighScoreText.text = "High Score: " + Mathf.RoundToInt(HighScore.highScore); ;
        CheckHighScore();
        if (Input.anyKey)
        {
            SceneManager.LoadScene(GameScene);
        }

    }

    void CheckHighScore()
    {
        if (GameManager.GameTimer > HighScore.highScore)
        {
            HighScore.highScore = Mathf.RoundToInt(GameManager.GameTimer);
        }
    }
}
