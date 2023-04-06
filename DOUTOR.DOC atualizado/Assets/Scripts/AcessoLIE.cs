using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoLIE : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo LobuloIE;

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if(LobuloIE != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    LobuloIE();
                
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
