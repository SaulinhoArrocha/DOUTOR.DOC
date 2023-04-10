using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoLID : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo LobuloLID;

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if(LobuloLID != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    LobuloLID();
                
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
