using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemaglutininaColeta : MonoBehaviour
{
    public GameObject hemaglutininaMala;

    bool verificarHema = false;

    void OnMouseDown()
    {
        Destroy(gameObject);
        hemaglutininaMala.SetActive(true);
        verificarHema = true;
    }
}
