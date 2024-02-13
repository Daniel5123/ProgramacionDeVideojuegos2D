using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseBase : MonoBehaviour
{
    public int Damage;
    public int Durabilidad;
    public int Rareza;

    public virtual void Ataque()
    {
        Debug.Log("Ataque");
    }
}

public class EspadaMadera : ClaseBase
{
    public EspadaMadera()
    {
        Damage = 4;
        Rareza = 59;
        Durabilidad = 60;
    }
}

public class EspadaPiedra : ClaseBase
{
    public EspadaPiedra()
    {
        Damage = 5;
        Rareza = 131;
        Durabilidad = 132;
    }
}

public class EspadaHierro : ClaseBase
{
    public EspadaHierro()
    {
        Damage = 6;
        Rareza = 250;
        Durabilidad = 251;
    }
}

public class EspadaOro : ClaseBase
{
    public EspadaOro()
    {
        Damage = 4;
        Rareza = 32;
        Durabilidad = 33;
    }
}

public class EspadaDiamante : ClaseBase
{
    public EspadaDiamante()
    {
        Damage = 7;
        Rareza = 1561;
        Durabilidad = 1562;
    }
}
