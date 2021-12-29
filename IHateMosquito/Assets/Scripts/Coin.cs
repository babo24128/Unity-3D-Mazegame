using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float speed = 5;
    Vector3 coindir;

    void Update()
    {
        transform.position += coindir * speed * Time.deltaTime;
        transform.Rotate(0.0f, 0.0f, -90.0f * Time.deltaTime);

    }

    void GetCoin()
    {
        GameManager.Instance.CalculatePlayerCoin();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GetCoin();
            Destroy(gameObject);
        }
    }
}
