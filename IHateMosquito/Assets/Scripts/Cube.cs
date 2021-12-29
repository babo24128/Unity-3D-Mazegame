using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Cube : MonoBehaviour
{


    public string nextSceneName;
    public GameObject panelStageClear;
    private int maxCubeCount;
    private int currentCubeCount;
    private bool getAllCube = false;

    public int MaxCubeCount => maxCubeCount;
    public int CurrentCubeCount => currentCubeCount;

    public float speed = 5;
    Vector3 coindir;

    void Update()
    {
        transform.position += coindir * speed * Time.deltaTime;
        transform.Rotate(0.0f, 0.0f, -90.0f * Time.deltaTime);

        if(getAllCube == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }

    }

    private void Awake()
    {
        Time.timeScale = 1.0f;
        panelStageClear.SetActive(false);

        maxCubeCount = GameObject.FindGameObjectsWithTag("Cube").Length;
        currentCubeCount = maxCubeCount;
    }

     public  void GetCube()
    {
        currentCubeCount--;

        if(currentCubeCount == 0)
        {
            getAllCube = true;
            Time.timeScale = 0.0f;
            panelStageClear.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GetCube();
            Destroy(gameObject);
        }
    }
}

