using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerMaxHP = 3;
    public int currentHP;

    public void Awake()
    {
        currentHP = playerMaxHP;
    }
}
