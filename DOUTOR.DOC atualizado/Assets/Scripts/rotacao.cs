using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    bool posicaoInicial; 

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                transform.Rotate (0, 90, 0); 


                
            }

        }
        //if (posicaoInicial == true){
            //estrutura.transform.localEulerAngles = Vector3.Lerp(estrutura.transform.localEulerAngles, Vector3.zero, Time.deltaTime); 

        //} else{
            //Vector3 rotacao45Graus = new Vector3(0, controler+90, 0); 
            //estrutura.transform.localEulerAngles = Vector3.Lerp(estrutura.transform.localEulerAngles, rotacao45Graus, Time.deltaTime);

        //}
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
