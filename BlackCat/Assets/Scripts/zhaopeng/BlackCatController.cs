using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCatController : MonoBehaviour
{
    public float Force = 20.0f;
    public float Distance = 2.2f;
    private float CurrentHeight;
    private Rigidbody2D BlackCat;
    private Animator Anim;
    private bool CatJump = false;

    private bool isDead = false;

    public bool Awesome;
    public Vector2 direction;
    private Transform Cat_Transform;

    // Start is called before the first frame update
    void Start()
    {
        BlackCat = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        Cat_Transform = GameObject.FindGameObjectWithTag("BlackCat").GetComponent<Transform>();
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
            BlackCat.AddForce(new Vector2(2.0f, Force));
            Anim.SetBool("Grounded", false);
        }

        if (isDead)
        {
            CircleCollider2D cir = BlackCat.GetComponent<CircleCollider2D>();
            BoxCollider2D box = BlackCat.GetComponentInChildren<BoxCollider2D>();
            cir.enabled = false;
            box.enabled = false;
            BlackCat.AddForce(new Vector2(-15.0f * Time.deltaTime, 15.0f * Time.deltaTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Rigidbody2D Car = collision.gameObject.GetComponent<Rigidbody2D>();
            CurrentHeight = transform.position.y;
            CatJump = true;
            Anim.SetBool("Grounded", true);
            Car.constraints = RigidbodyConstraints2D.None;
        }



        if(collision.gameObject.CompareTag("boucewall"))
        {
            ReverseMove();
            Cat_Transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {
            Destroy(collision.gameObject);
        }

        //if (collision.gameObject.CompareTag("Diamond"))
        //{
        //    isDead = true;
        //    Anim.SetTrigger("Dead");
        //    //Collider2D[] col = BlackCat.GetComponents<Collider2D>();
        //    //foreach (Collider2D c in col)
        //    //{
        //    //    c.enabled = false;
        //    //}
        //    //BlackCat.transform.Translate(new Vector2(-1.0f, 1.0f));
        //}

        if (collision.gameObject.CompareTag("Fire")|| collision.gameObject.CompareTag("Bat"))
        {
            isDead = true;
            Anim.SetTrigger("Dead");
        }
    }

    public void ReverseMove()
    {
        if (Awesome == true)
        {
            Debug.Log("111");
            BlackCat.velocity = direction;


        }
        else if (Awesome == false && Input.GetButton("Fire1"))
        {
            Debug.Log("222");
            BlackCat.velocity = direction;
        }
    }
}
