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
        print("CatJump:" + CatJump);
        print("Input:" + Input.GetButton("Fire1"));
        if (CatJump && Input.GetButton("Fire1"))
        {
            BlackCat.AddForce(new Vector2(5, Force));
            Anim.SetBool("Grounded", false);
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
