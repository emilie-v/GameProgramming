using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    public int health;

    public void Add(int v)
    {
        health += v;
    }

    public void RemoveHealth(int v)
    {
        health -= v;
    }
}
