using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("Activate", 1.0f);
    }

    private void Activate()
    {
        gameObject.SetActive(true);
    }
}
