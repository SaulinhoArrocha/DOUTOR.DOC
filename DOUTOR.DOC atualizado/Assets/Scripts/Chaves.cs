using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaves : MonoBehaviour
{
    [HideInInspector] public List<int> ChavesDoJogador = new List<int>();

    void Awake()
    {
        if (transform.gameObject.tag != "Player")
        {
            transform.gameObject.tag = "Player";
        }
    }
}
