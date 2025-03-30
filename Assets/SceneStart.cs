using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    public string GameScene;
    public KeyCode StartKey = KeyCode.K;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(StartKey))
        {
            SceneManager.LoadScene(GameScene);
        }
    }
}
