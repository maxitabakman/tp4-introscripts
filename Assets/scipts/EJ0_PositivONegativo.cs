using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ0_PositivONegativo : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 >0){
            Debug.Log ("El numero es positivo");}
        else if (num1 <0){
            Debug.Log ("El numero es negativo");}
        else {
            Debug.Log ("El numero es 0");}

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
