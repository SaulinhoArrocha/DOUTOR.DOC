using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemagluMala : MonoBehaviour
{
    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        hemagluCamera.SetActive(true);
        envelopeCcamera.SetActive(false);  
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCamera.SetActive(false);

    }
}
