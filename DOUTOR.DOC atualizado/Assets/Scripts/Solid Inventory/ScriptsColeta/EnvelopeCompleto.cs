using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCompleto : MonoBehaviour
{
    public GameObject envelopeCompletoMala;

    bool verificarEC;

    void OnMouseDown()
    {
        Destroy(gameObject);
        envelopeCompletoMala.SetActive(true);
        verificarEC = true;
    }
}
