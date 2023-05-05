using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMcoleta : MonoBehaviour
{
    public GameObject proteinaMmala;

    void OnMouseDown()
    {
        Destroy(gameObject);
        proteinaMmala.SetActive(true);
    }
}
