using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public GameObject fishPrefab;
    public float spawnInterval = 2f;
    public float fishSpeed = 3f;
    private bool spawnLeft = true;

    void Start()
    {
        InvokeRepeating("SpawnFishFunction", 1f, spawnInterval);
    }

    void SpawnFishFunction()
    {
        float xPos = spawnLeft ? -12f : 12f; 
        float yPos = Random.Range(-4f, 4f); 
        spawnLeft = !spawnLeft; 
        GameObject fish = Instantiate(fishPrefab, new Vector2(xPos, yPos), Quaternion.identity);
        FishMovement fishMovement = fish.GetComponent<FishMovement>();
        fishMovement.SetDirection(spawnLeft ? Vector2.left : Vector2.right, fishSpeed);

        Destroy(fish, 10f);
    }
}
