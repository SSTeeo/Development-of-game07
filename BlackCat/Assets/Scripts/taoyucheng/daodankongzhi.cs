using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daodankongzhi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("weiyan").GetComponent<SpriteRenderer>().enabled = false;
        //GameObject.Find("missile").GetComponent<Animator>().enabled = false;
        //GameObject.Find("yan").GetComponent<ParticleSystem>().Stop();
        GameObject.FindGameObjectWithTag("lizi").GetComponent<ParticleSystem>().Stop();
        GameObject.FindGameObjectWithTag("test").GetComponent<Animator>().enabled = false;
        GameObject.FindGameObjectWithTag("Missle").GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            //GameObject.Find("missile").GetComponent<Animator>().enabled = true;
            //GameObject.Find("weiyan").GetComponent<SpriteRenderer>().enabled = true;
            //GameObject.Find("yan").GetComponent<ParticleSystem>().Play();
            GameObject.FindGameObjectWithTag("lizi").GetComponent<ParticleSystem>().Play();
            GameObject.FindGameObjectWithTag("test").GetComponent<Animator>().enabled = true;
            GameObject.FindGameObjectWithTag("Missle").GetComponent<SpriteRenderer>().enabled = true;
        }

    }
    
}
