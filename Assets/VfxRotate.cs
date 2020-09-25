using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxRotate : MonoBehaviour
{

    Rigidbody rb;
    float durationTime = 10f;
    Vector3 direction = new Vector3(0f, 0f, 1f);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(0f, 0f, 200f);
        Debug.Log(rb.angularVelocity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
