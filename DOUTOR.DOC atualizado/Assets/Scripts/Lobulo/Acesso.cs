using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acesso : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo OnEnemyDied;
    


    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (OnEnemyDied != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    OnEnemyDied();

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
