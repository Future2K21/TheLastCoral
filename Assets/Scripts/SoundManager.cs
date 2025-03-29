using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private AudioSource AudioS;
    public AudioClip BubbleClip;

    private void Start()
    {
        instance = this;
        AudioS = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            AudioS = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BubbleSound()
    {
        AudioS.PlayOneShot(BubbleClip, 0.5f);
    }

}
