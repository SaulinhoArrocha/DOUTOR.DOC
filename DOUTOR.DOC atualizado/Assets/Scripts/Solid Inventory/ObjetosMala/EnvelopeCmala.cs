using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCmala : MonoBehaviour
{

    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        envelopeCcamera.SetActive(true);
        hemagluCamera.SetActive(false);
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCamera.SetActive(false);

    }
}
