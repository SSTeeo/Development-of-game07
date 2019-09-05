using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllower : MonoBehaviour
{
    public Transform BlackCat;
    private float distanceX;
    // Start is called before the first frame update
    void Start()
    {
        distanceX = transform.position.x - BlackCat.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            BlackCat.position.x + distanceX,
            transform.position.y,
            transform.position.z);
    }
}
