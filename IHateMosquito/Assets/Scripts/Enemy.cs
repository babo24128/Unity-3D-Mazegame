using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 5;
    Vector3 dir;
 
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
       
    }

    void AttackPlayer()
    {
        GameManager.Instance.CalculatePlayerLife(1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
          
            AttackPlayer();
            Destroy(gameObject);
        }
    }
}
