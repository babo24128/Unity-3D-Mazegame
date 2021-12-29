using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    //float currentTime;
    //float creatTime = 1;
    public GameObject enemyFactory;
    //public float minTime = 1;
    //public float maxTime = 5;
    public int MaxCount_Enemy;
    public GameObject[] Points;

    void Start()
    {
        //creatTime = Random.Range(minTime, maxTime);
        SpawnEnemys();
    }

    void SpawnEnemys()
    {
        for (int i = 0; i < MaxCount_Enemy; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = Points[i].transform.position;
            //[Random.Range(0, Points.Length)]
        }
    }
}
