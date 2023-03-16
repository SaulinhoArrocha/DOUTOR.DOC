using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public GameObject EnvelopeCompleto;
    public GameObject Hemaglutinina;
    public GameObject ProteinaM;
    public GameObject ProteinaSpike;
    public GameObject Rna;


    private void Awake()
    {
        Instance = this;
    }


    public void UsarEnvelope()
    {
        EnvelopeCompleto.SetActive(true);
    }

    public void UsarHemaglutinina()
    {
        Hemaglutinina.SetActive(true);
    }

    public void UsarProteinaM()
    {
        ProteinaM.SetActive(true);
    }

    public void UsarProteinaSpike()
    {
        ProteinaSpike.SetActive(true);
    }

    public void UsarRna()
    {
        Rna.SetActive(true);
    }
}
