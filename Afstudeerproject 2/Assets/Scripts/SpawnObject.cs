using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] spawnableObject;
    public Transform[] spawnPoints;

    private int RandomSpawnPoint;
    private int PreviousPoint;

    private void Start()
    {
        StartCoroutine("SpawnTimer");
    }

    IEnumerator SpawnTimer()
    {
        for(; ; )
        {
            RandomGameobject();
            yield return new WaitForSeconds(.8f);
        }
    }

    void RandomGameobject()
    {
        float randomNumber = Random.Range(1, 15);
        if(randomNumber > 1)
        {
            GenerateRandomSpawnPoint();
            InstantiateObject(spawnableObject[0]);
        }
        else
        {
            GenerateRandomSpawnPoint();
            InstantiateObject(spawnableObject[1]);
        }
    }

    void GenerateRandomSpawnPoint()
    {
        RandomSpawnPoint = Random.Range(0, 4);
        if (RandomSpawnPoint == PreviousPoint)
        {
            GenerateRandomSpawnPoint();
            return;
        }
        PreviousPoint = RandomSpawnPoint;
    }

    void InstantiateObject(GameObject gameObject)
    {
        Instantiate(gameObject, spawnPoints[RandomSpawnPoint].position, Quaternion.identity);
    }
}
