using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;


public class downLeft : MonoBehaviour
{
    public GameObject campodeSenha;
    public GameObject acessoLobuloIE;

    //bool control = true; 
    string Code = "SPIKE"; 
    string Letra = null; 
    int LetraIndex = 0; 
    string Alpha; 
    public Text UiText = null; 
    [SerializeField] private Animator Door; 

    public void CodeFunction(string Letras)
    {
        LetraIndex++; 
        Letra = Letra + Letras; 
        UiText.text = Letra;  

    }
    public void Enter()
    {
        if (Letra == Code)
        {
            //campodeSenha.SetActive(false);
            UiText.text = "Correto"; 
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
            //control = false; 
            
            
             
        }
        else
        {
            UiText.text = "Incorreto!"; 

        }
    }
    public void Delete()
    {
        LetraIndex++; 
        Letra = null; 
        UiText.text = Letra;
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(1f); 
        Door.SetBool("Open", false);
        Door.enabled = false; 
        campodeSenha.SetActive(false);
        Destroy(acessoLobuloIE);
    }
}
