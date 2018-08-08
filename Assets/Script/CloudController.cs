﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{


    private float minimum = 1.0f;
    private float magSpeed = 10.0f;
    private float magnification = 0.07f;




    // Update is called once per frame
    void Update()
    {

        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * magSpeed) * magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * magSpeed) * magnification);
    }
}
