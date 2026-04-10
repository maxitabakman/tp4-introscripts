using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2_IntroFunciones1 : MonoBehaviour
{
    //crear un funcion de acceso denegado 
//e implementar las funcionalidad que permitan ingresar por inspector
//una cadena de caracteres y ejecutar la funcion de mensaje de bienvenidad si
//el strig conincide con tic2026 sino denegarle el acceso    

  public string acceso;
    void Start()
    {         if (acceso == "tic2026"){
          MensajeBienvenida();}
        else {
          MensajeAccesoDenegado();}

    
    }
    void MensajeBienvenida(){
        Debug.Log("Bienvenido");
    }
       void MensajeAccesoDenegado(){
        Debug.Log("Acceso denegado");
    }
}
