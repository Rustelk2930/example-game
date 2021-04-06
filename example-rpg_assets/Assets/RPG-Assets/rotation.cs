﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
   [Range(-1000, 1000)] public float zRotation = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, zRotation);
    }
}
