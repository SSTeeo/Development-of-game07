using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_particle : MonoBehaviour
{
    public GameObject MParticle;
    // Start is called before the first frame update
    void Start()
    {
        MParticle.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("birdboss"))
        {
            Instantiate(MParticle, transform.position, Quaternion.identity);
            MParticle.SetActive(true);
        }
        
    }
}
