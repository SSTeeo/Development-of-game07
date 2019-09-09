using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inverter : MonoBehaviour
{
    
    private Transform Cat_Transform;

    void Start()
    {
        Cat_Transform = GameObject.FindGameObjectWithTag("BlackCat").GetComponent<Transform>();
    }

    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Cat_Transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}
