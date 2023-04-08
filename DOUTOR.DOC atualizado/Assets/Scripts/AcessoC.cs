using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoC : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo LobuloC;

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if(LobuloC != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    LobuloC();
                
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
