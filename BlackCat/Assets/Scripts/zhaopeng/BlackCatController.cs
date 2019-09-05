using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCatController : MonoBehaviour
{
    public float Force = 35.0f;
    public float Distance = 3.0f;
    private float CurrentHeight;
    private Rigidbody2D BlackCat;
    private Rigidbody2D Car;
    private Animator Anim;
    private bool CatJump = false;
    // Start is called before the first frame update
    void Start()
    {
        BlackCat = GetComponent<Rigidbody2D>();
        //Car = GameObject.Find("Car").GetComponent<Rigidbody2D>();
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
        print("CatJump:" + CatJump);
        print("Input:" + Input.GetButton("Fire1"));
        if (CatJump && Input.GetButton("Fire1"))
        {
            BlackCat.AddForce(new Vector2(0, Force));
            Anim.SetBool("Grounded", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Car")
        {
            Rigidbody2D rig = collision.gameObject.GetComponent<Rigidbody2D>();
            CurrentHeight = transform.position.y;
            CatJump = true;
            Anim.SetBool("Grounded", true);
            rig.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {
            Destroy(collision.gameObject);
        }
    }
}
