using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouRetrato : MonoBehaviour
{
    public GameObject retratoMala, retratoFinal, rretratoCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(retratoMala);
        rretratoCamera.SetActive(false);
        retratoFinal.SetActive(true);

    }
}
