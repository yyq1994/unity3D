using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public Transform Transform;
    public Rigidbody rb;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)&& Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody rb1;
            rb1 = Instantiate(rb, Transform.position, Transform.rotation) as Rigidbody;
            rb1.AddForce(Transform.forward * 500f);
        }
    }
}
