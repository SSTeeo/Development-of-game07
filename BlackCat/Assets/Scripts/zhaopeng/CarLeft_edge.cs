using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLeft_edge : MonoBehaviour
{
    private bool Adjust = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Adjust)
        {
            GameObject.FindGameObjectWithTag("BlackCat").transform.Translate(new Vector3(0.5f * Time.deltaTime, 0));
            Adjust = !Adjust;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            Adjust = true;
        }
    }
}
