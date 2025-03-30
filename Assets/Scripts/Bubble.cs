using UnityEngine;
using System.Collections;

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
        StartCoroutine("Flash");
    }


    void Update()
    {
        if (Vacuum && BubbleHealth > 0)
        {
            GameManager.PH += 0.1f;
            Vacuum = false;
            audioSource.PlayOneShot(BubbleSuck);
            SR.enabled = false;
            Destroy(gameObject, BubbleSuck.length);
            return;
        }

        BubbleHealth -= Time.deltaTime;
        if (BubbleHealth <= 0f && CanDestroyBool)
        {
            GameManager.PH -= 0.1f;
            CanDestroyBool = false;
            audioSource.PlayOneShot(BubblePop);
            SR.enabled = false;
            Destroy(gameObject, BubblePop.length);
        }
    }

    public void SetTrue()
    {
        Vacuum = true;
    }

    public IEnumerator Flash()
    {
        yield return new WaitForSeconds(8);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
        yield return new WaitForSeconds(0.2f);
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
        yield return new WaitForSeconds(0.2f);


    }

}
