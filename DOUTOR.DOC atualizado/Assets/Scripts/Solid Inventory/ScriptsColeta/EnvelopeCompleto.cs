using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCompleto : MonoBehaviour
{
    public GameObject envelopeCompletoMala;

    void OnMouseDown()
    {
        Destroy(gameObject);
        envelopeCompletoMala.SetActive(true);
    }
}
