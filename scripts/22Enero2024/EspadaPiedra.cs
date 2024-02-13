using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaPiedr : ClaseBase
{
    public Sprite swordSprite;
    void Awake()
    {
        Damage = 5;
        Rareza = 131;
        Durabilidad = 132;
    }

    public override void Ataque()
    {
        Debug.Log("Ataque piedra: ");
    }
}
