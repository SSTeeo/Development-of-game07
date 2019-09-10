using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject FireP;
    // Start is called before the first frame update
    void Start()
    {
        FireP.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(FireP, transform.position, Quaternion.identity);
        FireP.SetActive(true);
        Destroy(gameObject);
    }

}
