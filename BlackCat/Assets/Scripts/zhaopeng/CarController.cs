using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D LwheelJoint;
    public WheelJoint2D RwheelJoint;
    private JointMotor2D Left;
    private JointMotor2D Right;
    // Start is called before the first frame update
    void Start()
    {
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
        //if (collision.gameObject.name == "Diamond")
        //{
        //    Left.motorSpeed = -750;
        //    Right.motorSpeed = -750;
        //    LwheelJoint.motor = Left;
        //    RwheelJoint.motor = Right;
        //}

        if (collision.gameObject.name == "BlackCat")
        {
            LwheelJoint.useMotor = true;
            RwheelJoint.useMotor = true;
        }
    }
}
