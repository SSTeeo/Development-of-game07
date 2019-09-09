//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class keyControl : MonoBehaviour
//{
//    private SpriteRenderer ren;
//    public Sprite OffImage;
//    public SwitchMethod Type;
//    public GameObject[] ControlObjects;
//    // Start is called before the first frame update
//    void Start()
//    {
//        ren = GetComponent<SpriteRenderer>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        GameObject hero = collision.gameObject;
//        BlackCatController herocon = hero.GetComponent<BlackCatController>();
//        if(hero.CompareTag("player"))
//        {
//            ren.sprite = OffImage;
//        }
//    }
//}
