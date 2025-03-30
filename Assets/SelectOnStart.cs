using UnityEngine;
using UnityEngine.UI;
public class SelectOnStart : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button b = GetComponent<Button>();
        b.Select();

    }

}
