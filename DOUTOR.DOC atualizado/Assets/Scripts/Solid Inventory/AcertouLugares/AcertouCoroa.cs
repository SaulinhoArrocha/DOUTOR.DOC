using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCoroa : MonoBehaviour
{
    public GameObject coroaMala, coroaFinal, coroaCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(coroaMala);
        coroaCamera.SetActive(false);
        coroaFinal.SetActive(true);

    }
}
