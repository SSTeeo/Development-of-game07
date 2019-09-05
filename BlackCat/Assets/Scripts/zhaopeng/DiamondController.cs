using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondController : MonoBehaviour
{
    public GameObject DiaParticle;
    // Start is called before the first frame update
    void Start()
    {
        //DiaParticle.SetActive(false);
        DiaParticle.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(DiaParticle, transform.position, Quaternion.identity);
        DiaParticle.SetActive(true);
    }
}
