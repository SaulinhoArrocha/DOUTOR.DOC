using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoLSE : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo LobuloSE;

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if(LobuloSE != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    LobuloSE();
                
                }

            }

        }
    }


    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }
    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
