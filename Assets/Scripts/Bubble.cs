using UnityEngine;

public class Bubble : MonoBehaviour
{

    public float BubbleHealth = 10f;
    public bool Vacuum;
    public SpriteRenderer SR;
    public AudioSource audioSource;
    public AudioClip BubblePop;
    public AudioClip BubbleSuck;

    private bool CanDestroyBool;

    void Start()
    {
        Vacuum = false;
        CanDestroyBool = true;
    }


    void Update()
    {
        if (Vacuum == true)
        {
            Vacuum = false;
            audioSource.PlayOneShot(BubbleSuck);
            SR.enabled = false;
            Destroy(gameObject, BubbleSuck.length);
            Vacuum = true;
        }

        float DestroyTimer = Time.deltaTime;
       BubbleHealth -= DestroyTimer;
       if(BubbleHealth < 0f && CanDestroyBool == true)
            {
            CanDestroyBool = false;
            audioSource.PlayOneShot(BubblePop);
            SoundManager.instance.BubbleSound();
            Debug.Log("Destroy Bubble");
            SR.enabled = false;
            Destroy(gameObject, BubblePop.length);
            CanDestroyBool = true;
        }
    }
}
