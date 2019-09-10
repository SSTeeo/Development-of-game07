using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    public Animator Head;
    public  int Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            Count = Count + 1;
            if (Count == 10)
            {
                Head.enabled = true;
            }
        }
    }
}
