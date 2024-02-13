using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaOr : ClaseBase
{
    public Sprite swordSprite;
    void Awake()
    {
        Damage = 4;
        Rareza = 32;
        Durabilidad = 33;
    }

    public override void Ataque()
    {
        Debug.Log("Ataque oro: ");
    }
}
