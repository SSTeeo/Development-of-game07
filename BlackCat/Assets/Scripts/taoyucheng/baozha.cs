using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baozha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("baozha").GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BOSS"))
        {
            GameObject.Find("baozha").GetComponent<ParticleSystem>().Play();
        }
    }
    
}
