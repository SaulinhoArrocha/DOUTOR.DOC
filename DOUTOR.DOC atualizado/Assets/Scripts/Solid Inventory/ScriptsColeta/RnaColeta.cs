using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RnaColeta : MonoBehaviour
{
    public GameObject rnaMala;

    void OnMouseDown()
    {
        Destroy(gameObject);
        rnaMala.SetActive(true);
    }
}
