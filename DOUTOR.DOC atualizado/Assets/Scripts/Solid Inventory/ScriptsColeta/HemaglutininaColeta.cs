using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemaglutininaColeta : MonoBehaviour
{
    public GameObject hemaglutininaMala;


    void OnMouseDown()
    {
        Destroy(gameObject);
        hemaglutininaMala.SetActive(true);
    }
}
