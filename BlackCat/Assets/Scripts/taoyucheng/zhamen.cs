using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhamen : MonoBehaviour
{
    public GameObject switch_off;
    public Sprite juchi1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switch_off.GetComponent<kaiguan>().s == false)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
