using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMorcego : MonoBehaviour
{
    public GameObject morcegoMala, morcegoFinal, morcegoCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(morcegoMala);
        morcegoCamera.SetActive(false);
        morcegoFinal.SetActive(true);

    }
}
