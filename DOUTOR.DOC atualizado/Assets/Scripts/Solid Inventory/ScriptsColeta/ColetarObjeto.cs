using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarObjeto : MonoBehaviour
{
    public GameObject ativarObjeto;

    void OnMouseDown()
    {
        Destroy(gameObject); 
        ativarObjeto.SetActive(true); 
    }
}
