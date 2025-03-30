using UnityEngine;

public class BubbleCreator : MonoBehaviour
{
    public GameObject BubblePrefab; 
    public float spawnDelay = 5f;
    void Start()
    {
        InvokeRepeating("SpawnBubbles", spawnDelay, spawnDelay);
    }
    public void SpawnBubbles()
    {
        var position = new Vector3(Random.Range(-6.0f, 12.0f), Random.Range(-5.5f, -1f), 0);
        Instantiate(BubblePrefab,position, Quaternion.identity);
        Debug.Log("Spawned Bubble");

        

    }
}
