using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secene_Manager : MonoBehaviour
{
    public static bool gameOver;


    void Awake()
    {
        gameOver = false;
    }


    void Update()
    {
        if(gameOver && Input.GetKeyDown(KeyCode.Y)) { 
        

        }
    }
}
