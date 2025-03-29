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
        if (Vacuum && BubbleHealth > 0)
        {
            Vacuum = false;
            audioSource.PlayOneShot(BubbleSuck);
            SR.enabled = false;
            Destroy(gameObject, BubbleSuck.length);
            return;
        }

        BubbleHealth -= Time.deltaTime;
        if (BubbleHealth <= 0f && CanDestroyBool)
        {
            CanDestroyBool = false;
            audioSource.PlayOneShot(BubblePop);
            SoundManager.instance.BubbleSound();
            SR.enabled = false;
            Destroy(gameObject, BubblePop.length);
        }
    }

}
