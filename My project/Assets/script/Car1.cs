using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    public float speed = 0.75f;
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
            speed = 0.5f;
            if(Physics.Raycast(transform.position, transform.forward, out hit, lineSize / 2))
            {
                speed = 0;
            }
        }
        else
        {
            rigid.AddForce(transform.forward * speed);
        }
    }
}
