﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMovement : MonoBehaviour
{
     public Vector3 MovementSpeed = new Vector3(0f, 0f, 10f);
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        transform.Translate(MovementSpeed * Time.deltaTime);
    }
}
