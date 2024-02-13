using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int edad = 20;

    // Start is called before the first frame update
    void Start()
    {
        int resultado = suma(5, 5);
        Debug.Log("El resultado es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void walk(/*parametros*/)
    {

    }
    int suma (int x, int y)
    {
        return x + y;
    }
}
