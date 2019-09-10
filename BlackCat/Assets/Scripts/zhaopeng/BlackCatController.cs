using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCatController : MonoBehaviour
{
    public float ForceX = 2.0f;
    public float ForceY = 20.0f;
    public float Distance = 2.2f;
    public static float Count = 0;
    public iTween.EaseType type;

    public AudioClip DiamondCollect;

    private float CurrentHeight;
    private Rigidbody2D BlackCat;
    private Animator Anim;
    private bool CatJump = false;
    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        BlackCat = GetComponent<Rigidbody2D>();
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
            BlackCat.AddForce(new Vector2(ForceX, ForceY));
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

        if (collision.gameObject.name == "Spring")
        {
            Hashtable args = new Hashtable();
            args.Add("speed", 10.0f);
            args.Add("path", iTweenPath.GetPath("MyPath"));
            args.Add("easeType", type);
            iTween.MoveTo(gameObject, args);
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {
            AudioSource.PlayClipAtPoint(DiamondCollect, Camera.main.transform.position);
            Destroy(collision.gameObject);
            Count++;
            Debug.Log(Count);
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
}
