using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batdead : MonoBehaviour
{
    private bool isDead = false;
    private Animator Anim = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isDead = true;
            Anim.SetBool("Dead", isDead);
            Anim.SetTrigger("DeadOnce");
        }
    }
}
