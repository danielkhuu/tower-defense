﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform targetEnemy;

    void Update()
    {
        LookAtEnemy();
    }
    private void LookAtEnemy()
    {
        objectToPan.LookAt(targetEnemy);
    }
}