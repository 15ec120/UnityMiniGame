﻿using UnityEngine;
using System.Collections;

public class RotateCupsule : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30));
    }
}