using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    public string Player1Scene;
    public string Player2Scene;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void StartPlayer1()
    {
        SceneManager.LoadScene(Player1Scene);
    }
    public void StartPlayer2()
    {
        SceneManager.LoadScene(Player2Scene);
    }


}
