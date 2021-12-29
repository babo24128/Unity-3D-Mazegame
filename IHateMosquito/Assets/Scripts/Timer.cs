﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;

    void Update()
    {
        LimitTime += Time.deltaTime;
        text_Timer.text = "경과시간 : " + Mathf.Round(LimitTime);
    }
}
