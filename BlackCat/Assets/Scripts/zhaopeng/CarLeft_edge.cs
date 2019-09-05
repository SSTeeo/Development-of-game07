using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLeft_edge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "BlackCat")
        {
            collision.gameObject.transform.Translate(new Vector3(0.3f, 0));
        }
    }
}
