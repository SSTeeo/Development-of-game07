using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaiguan : MonoBehaviour
{
    public Sprite switch_on;
    public Sprite switch_off;
    public bool s = true;
    //public float ChangeSpriteInterval = 0.5f;
    //private float totalTime = 0;
    //private SpriteRenderer render = null;
    // Start is called before the first frame update
    void Start()
    {
        //render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //totalTime += Time.deltaTime;
        //if (totalTime >= ChangeSpriteInterval)
        //{
        //    isLaserOn = !isLaserOn;
        //    //totalTime = 0;
        //}
        //render.sprite = isLaserOn ? switch_off : switch_on;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlackCat"))
        {
            GetComponent<SpriteRenderer>().sprite = switch_on;
            s = false;

            /*collision.gameObject*/GetComponent<AudioSource>().Play();
        }
    }
}
