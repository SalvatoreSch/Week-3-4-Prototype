﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDownTimer : MonoBehaviour
{
    public float timeRemaining = 10;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}