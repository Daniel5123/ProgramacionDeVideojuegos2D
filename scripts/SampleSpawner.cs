using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public int RoundCount = 5;
    public float TimeBetweenRounds = 3;
    public int SpawnArea = 5;
    public List<GameObject> prefabs;

    [Header("DEBUG")]
    public float currentTime = 0f;
    public int currentRound = 0;

    public void Spawner()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= TimeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0f;
            currentRound++;

            if(currentRound >= RoundCount)
            {
                currentRound = 0;
                TimeBetweenRounds *= 0.9f;
            }
        }
    }

    public void ObjectGeneration()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnArea, SpawnArea),
                                            Random.Range(-SpawnArea, SpawnArea), 0);
        GameObject obj = prefabs[Random.Range(0, prefabs.Count)];
        GameObject clone = Instantiate(obj, SpawnPosition, Quaternion.identity);
        clone.transform.parent = transform;
    }

    private void Update()
    {
        Spawner();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(SpawnArea, SpawnArea, 0));
    }

}