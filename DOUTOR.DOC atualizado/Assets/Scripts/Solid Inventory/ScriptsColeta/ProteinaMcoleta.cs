using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMcoleta : MonoBehaviour
{
    public GameObject proteinaMmala;

    bool verificarPM = false;

    void OnMouseDown()
    {
        Destroy(gameObject);
        proteinaMmala.SetActive(true);
        verificarPM = true;
    }
}
