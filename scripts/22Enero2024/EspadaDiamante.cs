using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaDiamant : ClaseBase
{
    public Sprite swordSprite;
    void Awake()
    {
        Damage = 7;
        Rareza = 1561;
        Durabilidad = 1562;
    }

    public override void Ataque()
    {
        Debug.Log("Ataque diamante: ");
    }
}
