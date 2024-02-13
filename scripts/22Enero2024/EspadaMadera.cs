using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaMader : ClaseBase
{
    public Sprite swordSprite;
    private void Awake()
    {
        Damage = 4;
        Durabilidad = 60;
        Rareza = 60;
    }

    public override void Ataque()
    {
        Debug.Log("Daño madera: ");
    }
}
