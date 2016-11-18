﻿using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();

        if (Input.GetKeyDown(KeyCode.Space))
            if (camera.orthographic)
                camera.orthographic = false;
            else
                camera.orthographic = true;
    }
}
