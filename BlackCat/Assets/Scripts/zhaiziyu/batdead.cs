﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batdead : MonoBehaviour
{
    private Rigidbody2D GG;
    // Start is called before the first frame update
    void Start()
    {

        GG = GetComponent<Rigidbody2D>();

    }

// Update is called once per frame
void Update()
{

}

private void OnTriggerEnter2D(Collider2D collision)
{
    gameObject.transform.parent.Find("greenbatbody").GetComponent<Rigidbody2D>().simulated = true;
        //GG.GetComponent<Rigidbody2D>().AddTorque(0, 2);
    }

}
