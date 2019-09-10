using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daodankongzhi : MonoBehaviour
{
    //public GameObject[] M;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("weiyan").GetComponent<SpriteRenderer>().enabled = false;
        //GameObject.Find("missile").GetComponent<Animator>().enabled = false;
        //GameObject.Find("yan").GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("BlackCat"))
        //{
        //    GameObject.Find("missile").GetComponent<Animator>().enabled = true;
        //    GameObject.Find("weiyan").GetComponent<SpriteRenderer>().enabled = true;
        //    GameObject.Find("yan").GetComponent<ParticleSystem>().Play();
        //}
    }
    
}
