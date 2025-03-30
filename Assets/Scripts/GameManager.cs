using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float PH = 7.0f;
    public Coral coral;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PH = 7.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PH);
        coral.GameOver();
    }

    public void PHSubtract()
    {
        PH -= 0.1f;
    }
    public void PHAdd()
    {
        PH += 0.1f;
    }


}
