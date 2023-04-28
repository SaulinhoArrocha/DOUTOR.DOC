using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMmala : MonoBehaviour
{
    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        proteinaMcamera.SetActive(true);
        envelopeCcamera.SetActive(false);
        hemagluCamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCamera.SetActive(false);

    }
}
