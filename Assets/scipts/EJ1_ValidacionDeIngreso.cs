using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1_ValidacionDeIngreso : MonoBehaviour
{
    public int num2;

    //Permitir el ingreso por insperctor de un numero entero
    //Si el numero es mayor que 1900 y menor que 2027
    //escribir en consola gracias , caso contrario escribir año no valido
    // Start is called before the first frame update
    void Start()
    {
         if (num2 >1900 && num2 <2027){
            Debug.Log ("gracias");}
        else {
            Debug.Log ("numero no valido");}

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
