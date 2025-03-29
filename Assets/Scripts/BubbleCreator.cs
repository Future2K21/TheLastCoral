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
        var position = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-4.5f, 4.5f), 0);
        Instantiate(BubblePrefab,position, Quaternion.identity);
        Debug.Log("Spawned Bubble");

        

    }
}
