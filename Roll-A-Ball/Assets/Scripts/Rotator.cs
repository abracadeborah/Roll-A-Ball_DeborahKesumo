﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        Vector3 turn = new Vector3(15, 30, 45) * Time.deltaTime;
        transform.Rotate(turn);
    }
}
