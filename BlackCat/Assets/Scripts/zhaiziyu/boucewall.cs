using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucewall : MonoBehaviour
{
    public bool Awesome;
    public Vector2 direction;
    private Transform Cat_Transform;
    private Rigidbody2D rig;
    private SpriteRenderer c;
    // Start is called before the first frame update
    void Start()
    {
        Cat_Transform = GameObject.FindGameObjectWithTag("BlackCat").GetComponent<Transform>();
        rig = Cat_Transform.GetComponent<Rigidbody2D>();
        c = Cat_Transform.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            ReverseMove();
            c.flipX = true;
        }
    }

    public void ReverseMove()
    {
        if (Awesome == true)
        {
            rig.velocity = direction;


        }
        else if (Awesome == false && Input.GetButton("Fire1"))
        {
            rig.velocity = direction;
        }
    }
}
