using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCoroa : MonoBehaviour
{
    public GameObject coroaMala, coroaFinal, coroaCamera, teste;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;

    private void OnMouseDown()
    {
        coroaFinal.SetActive(true);

        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {
            teste.SetActive(true);


            Destroy(gameObject);
            Destroy(coroaMala);
            coroaCamera.SetActive(false);


        }
        else
        {
            Destroy(gameObject);
            Destroy(coroaMala);
            coroaCamera.SetActive(false);
        }

    }
}
