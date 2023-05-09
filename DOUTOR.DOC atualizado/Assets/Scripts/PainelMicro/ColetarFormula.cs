using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarFormula : MonoBehaviour
{
    public GameObject amostraMala;


    void OnMouseDown()
    {
        Destroy(gameObject);
        amostraMala.SetActive(true);
    }
}
