using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMascara : MonoBehaviour
{
    public GameObject mascaraMala, mascaraFinal, mascaraCamera, teste;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;

    private void OnMouseDown()
    {

        mascaraFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {
            teste.SetActive(true);


            Destroy(gameObject);
            Destroy(mascaraMala);
            mascaraCamera.SetActive(false);


        }
        else
        {
            Destroy(gameObject);
            Destroy(mascaraMala);
            mascaraCamera.SetActive(false);
        }

    }
}
