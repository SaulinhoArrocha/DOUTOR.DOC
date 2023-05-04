using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCarta : MonoBehaviour
{
    public GameObject cartaMala, cartaFinal, cartaCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(cartaMala);
        cartaCamera.SetActive(false);
        cartaFinal.SetActive(true);

    }
}
