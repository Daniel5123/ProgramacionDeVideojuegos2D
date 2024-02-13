using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaHierr : ClaseBase
{
    public Sprite swordSprite;
    void Awake()
    {
        Damage = 6;
        Rareza = 250;
        Durabilidad = 251;
    }

    public override void Ataque()
    {
        Debug.Log("Ataque hierro: ");
    }
}
