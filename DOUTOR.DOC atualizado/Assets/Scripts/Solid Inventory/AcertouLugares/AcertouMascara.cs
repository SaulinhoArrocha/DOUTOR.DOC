using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMascara : MonoBehaviour
{
    public GameObject mascaraMala, mascaraFinal, mascaraCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(mascaraMala);
        mascaraCamera.SetActive(false);
        mascaraFinal.SetActive(true);

    }
}
