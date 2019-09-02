using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCatController : MonoBehaviour
{
    public float Force = 35.0f;
    public float Distance = 3.0f;
    private float CurrentHeight;
    private Rigidbody2D Cat;
    private Animator Anim;
    private bool CatJump = true;
    // Start is called before the first frame update
    void Start()
    {
        Cat = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (transform.position.y - CurrentHeight >= Distance)
        {
            CatJump = false;

        }

        if (CatJump && Input.GetButton("Fire1"))
        {
            Cat.AddForce(new Vector2(0, Force));
            Anim.SetBool("Grounded", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Car")
        {
            CurrentHeight = transform.position.y;
            CatJump = true;
            Anim.SetBool("Grounded", true);
        }
       
    }
}
