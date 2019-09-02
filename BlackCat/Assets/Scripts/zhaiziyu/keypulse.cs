using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypulse : MonoBehaviour
{
    // Start is called before the first frame update
    private bool keypulse1 = false;
    Vector3 mousePositionOnScreen;

    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        keypulse1 = GameObject.FindGameObjectWithTag("keypulse1");
        Transform trans = GetComponent<Transform>();
        Animation ani = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            var world = Camera.main.ScreenToWorldPoint(mousePosition);
            gameObject.transform.position = world;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}
