﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
       int i = 0;
    public Renderer rend;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("<"+gameObject.name+">" + ":"+ i);
        i++;
    }
}
