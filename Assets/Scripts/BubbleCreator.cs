using UnityEngine;

public class BubbleCreator : MonoBehaviour
{
    public GameObject BubblePrefab; 
    public float spawnDelay = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [System.Obsolete]
    private void Start()
    {
        InvokeRepeating("SpawnBubbles", spawnDelay, spawnDelay);
    }



    [System.Obsolete]
    public void SpawnBubbles()
    {
        var position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-5.5f, 2.5f), 0);
        Instantiate(BubblePrefab,position, Quaternion.identity);
        Debug.Log("Spawned Bubble");

        

    }
}
