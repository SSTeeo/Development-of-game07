﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Missile"))
        {
            gameObject.transform.Translate(new Vector3(-1.0f, 0));
            Destroy(collision.gameObject,0.1f);
        }
    }
}
