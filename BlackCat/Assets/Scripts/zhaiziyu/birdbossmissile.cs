using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdbossmissile : MonoBehaviour
{
    private bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (move)
        {
            gameObject.transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0));
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            move = true;
            
        }
        //if (collision.gameObject.CompareTag("birdboss"))
        //{
        //    gameObject.transform.Translate(new Vector3(-5.0f, 0));
        //    Destroy(gameObject,1.0f);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("birdboss"))
        //{
        //    gameObject.transform.Translate(new Vector3(-1.0f, 0));
        //    Destroy(gameObject,1.0f);
        //}
    }
}
