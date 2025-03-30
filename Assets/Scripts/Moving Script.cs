using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public Vector3 Move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Move = new Vector2(0, Random.Range(0.005f, 0.001f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Move;
    }
}
