using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perro : animal
{
    [Header("CLASE DERIVADA")]
    public string Raza;
    // Start is called before the first frame update
    void Start()
    {
        /*Name = "Juan";*/
        Display();
    }
    public override void move()
    {
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;
        Vector3 direccion = (posicionMouse - transform.position).normalized;
        transform.Translate(direccion * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
