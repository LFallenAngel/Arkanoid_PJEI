﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerVida : MonoBehaviour
{

    public int vida = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("runa"))
        {

            vida = +1;
        }
    }
}
