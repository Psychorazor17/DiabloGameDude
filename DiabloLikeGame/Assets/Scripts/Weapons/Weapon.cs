﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {

    public float minDamage = 1.0f;
    public float maxDamage = 10.0f;


    public abstract float WeaponDamage();
    /*
    {
        return Random.Range(minDamage, maxDamage);
    }*/
}
