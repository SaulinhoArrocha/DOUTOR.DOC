using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaSpikeColeta : MonoBehaviour
{
    public GameObject proteinaSpikeMala;


    void OnMouseDown()
    {
        Destroy(gameObject);
        proteinaSpikeMala.SetActive(true);
    }
}
