using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batdead : MonoBehaviour
{
    private Rigidbody2D GG;
    //private Animator anim = null;
    //private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        GG = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.parent.Find("redbat").GetComponent<Rigidbody2D>().simulated = true;
        //anim.SetBool("Dead", isDead);
        //anim.SetTrigger("Deadonce");

        //GG.GetComponent<Rigidbody2D>().AddTorque(0, 2);
    }

}
