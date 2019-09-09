using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D LwheelJoint;
    public WheelJoint2D RwheelJoint;
    private JointMotor2D Left;
    private JointMotor2D Right;
    private SpriteRenderer SR;
    private float Speed = 900;
    // Start is called before the first frame update
    void Start()
    {
        SR = GameObject.FindGameObjectWithTag("BlackCat").GetComponent<SpriteRenderer>();
        LwheelJoint.useMotor = false;
        RwheelJoint.useMotor = false;
        Left = LwheelJoint.motor;
        Right = RwheelJoint.motor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            LwheelJoint.useMotor = true;
            RwheelJoint.useMotor = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Inverter"))
        {
            Left.motorSpeed = -Speed;
            Right.motorSpeed = -Speed;
            LwheelJoint.motor = Left;
            RwheelJoint.motor = Right;
            SR.flipX = !SR.flipX;
            Speed = -Speed;
        }
    }
}
