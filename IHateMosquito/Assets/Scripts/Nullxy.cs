using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nullxy : MonoBehaviour
{
    public Transform nullposition;
    void Start()
    {

    }


    void Update()
    {
        transform.position = nullposition.position;
    }
}