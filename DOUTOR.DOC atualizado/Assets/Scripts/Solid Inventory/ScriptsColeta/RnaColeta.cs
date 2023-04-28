using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RnaColeta : MonoBehaviour
{
    public GameObject rnaMala;

    bool verificarRNA = false;

    void OnMouseDown()
    {
        Destroy(gameObject);
        rnaMala.SetActive(true);
        verificarRNA = true;
    }
}
