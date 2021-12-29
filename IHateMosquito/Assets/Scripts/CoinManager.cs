using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public GameObject coinFactory;
    public int MaxCount_Coin;
    public GameObject[] Points;

    void Start()
    {
        SpawnEnemys();
    }

    void SpawnEnemys()
    {
        for (int i = 0; i < MaxCount_Coin; i++)
        {
            GameObject coin = Instantiate(coinFactory);
            coin.transform.position = Points[i].transform.position;
            //[Random.Range(0, Points.Length)]
        }
    }
}

