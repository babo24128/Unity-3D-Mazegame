using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{

    public Slider HPBar;
 
    private void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            HPBar.value -= 0.1f;
        }
    }
}
