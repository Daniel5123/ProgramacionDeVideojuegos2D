using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAleatorio : MonoBehaviour
{
    public List<GameObject> prefabs;
    public float tiempoEntreEstancias = 3f;
    public float radioSpawn = 5f;

    [Header("DEBUG")]
    public Vector3 SpawnPosition;
    public Color color;

    private void Start()
    {
        InvokeRepeating("InstanciarObjetoAleatorio", 0f, tiempoEntreEstancias);
    }

    private void InstanciarObjetoAleatorio()
    {
        Vector3 posicionAleatoria = Random.insideUnitCircle * radioSpawn;
        posicionAleatoria.z = 0f;

        GameObject RandomObj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject nuevoObjeto = Instantiate(RandomObj, SpawnPosition + posicionAleatoria, Quaternion.identity);

        SpriteRenderer spriteRenderer = nuevoObjeto.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        nuevoObjeto.transform.parent = transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnPosition, radioSpawn);
    }
}
