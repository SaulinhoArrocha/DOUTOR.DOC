using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCarta : MonoBehaviour
{
    public GameObject cartaMala, cartaFinal, cartaCamera, teste;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;

    private void OnMouseDown()
    {
        cartaFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {
            teste.SetActive(true);


            Destroy(gameObject);
            Destroy(cartaMala);
            cartaCamera.SetActive(false);


        }
        else
        {
            Destroy(gameObject);
            Destroy(cartaMala);
            cartaCamera.SetActive(false);
        }

    }
}
