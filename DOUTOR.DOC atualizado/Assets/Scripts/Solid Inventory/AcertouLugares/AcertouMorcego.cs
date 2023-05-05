using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMorcego : MonoBehaviour
{
    public GameObject morcegoMala, morcegoFinal, morcegoCamera, teste;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;

    private void OnMouseDown()
    {

        morcegoFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {
            teste.SetActive(true);


            Destroy(gameObject);
            Destroy(morcegoMala);
            morcegoCamera.SetActive(false);


        }
        else
        {
            Destroy(gameObject);
            Destroy(morcegoMala);
            morcegoCamera.SetActive(false);
        }

    }
}
