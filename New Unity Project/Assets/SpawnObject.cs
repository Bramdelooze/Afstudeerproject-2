using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnableObject;
    [SerializeField] private Transform[] spawnPoints;


    private void Start()
    {
        StartCoroutine("SpawnTimer");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }

    IEnumerator SpawnTimer()
    {
        for(; ; )
        {
            InstantiateObject();
            yield return new WaitForSeconds(.8f);
        }
    }

    void InstantiateObject()
    {
        GameObject randomGameobject = RandomGameObject();
        float ZPosition = randomGameobject.transform.position.z;
        Instantiate(randomGameobject, SpawnPointWithoutZ(spawnPoints[RandomNumber(0, spawnPoints.Length)].position, ZPosition), Quaternion.identity);
    }

    GameObject RandomGameObject()
    {
        return spawnableObject[0];
    }

    Vector3 SpawnPointWithoutZ(Vector3 spawnPoint, float originalZPos)
    {
        return new Vector3(spawnPoint.x, spawnPoint.y, originalZPos);
    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}
