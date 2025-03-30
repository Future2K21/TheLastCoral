using UnityEngine;

public class ShareAir : MonoBehaviour
{
    public PlayerController playerController;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerController.ShareOxygen();
        }
    }


}
