using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 2.5f;
    public Rigidbody rigid;
    public float lineSize = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(transform.forward * speed);
        Debug.DrawRay(transform.position, transform.forward * lineSize, Color.green);

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, lineSize))
        {
            Debug.Log(speed);
            speed = 0f;
        }
        else
        {
            speed = 2.5f;
            rigid.AddForce(transform.forward * speed);
        }
    }
}
