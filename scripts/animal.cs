using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{
    [Header("CLASE BASE")]
    public string Name = "animal";
    public float speed = 5f;
    public Vector3 posicionMouse;

    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouse.z = 0f;


        }
            Vector3 direccion = (posicionMouse - transform.position).normalized;

        if (direccion == transform.position)
        {
            return;
        }
        else
        {
            transform.Translate(direccion * speed * Time.deltaTime);

        }
    }

    public virtual void Display()
    {
        Debug.Log("El nombre del animal es: " + Name);
    }
}
