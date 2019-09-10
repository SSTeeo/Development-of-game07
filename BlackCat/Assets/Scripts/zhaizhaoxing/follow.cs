using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    private Transform m;
    // Start is called before the first frame update
    void Start()
    {
        m = GameObject.FindGameObjectWithTag("Boss"). GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, m.position, 0.1f);
    }
}
