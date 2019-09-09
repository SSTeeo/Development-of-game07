using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batdead1 : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D GG;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {

        GG = GetComponent<Rigidbody2D>();
        rig = GameObject.FindGameObjectWithTag("BlackCat").GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.parent.Find("redbatbody").GetComponent<Rigidbody2D>().simulated = true;
        //GG.GetComponent<Rigidbody2D>().AddTorque(0, 2);
        gameObject.transform.parent.gameObject.transform.eulerAngles = new Vector3(0, 0, 60.0f);
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            ReverseMove();
        }
    }

    public void ReverseMove()
    {
        rig.velocity = direction;
    }
}
