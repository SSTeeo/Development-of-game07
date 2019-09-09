using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatmissile : MonoBehaviour
{
    public GameObject missile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(missile, new Vector3(16, 4, 0), Quaternion.identity);
    }
}
