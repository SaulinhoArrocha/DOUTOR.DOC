using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RnaMala : MonoBehaviour
{
    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        rnaCamera.SetActive(true);
        envelopeCcamera.SetActive(false);
        hemagluCamera.SetActive(false);
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        envelopeCamera.SetActive(false);

    }
}
