using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    bool touched = false;

    int forwardSpeed=5;

    void Start()
    {
        
    }


    void Update()
    {
        if(touched)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody>().AddForce((Vector3.up + gameObject.transform.forward) * 250);
            }
            
            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.Self);
            }
            else if (Input.GetKey(KeyCode.S))
            {

                transform.Translate(Vector3.back * Time.deltaTime * forwardSpeed / 2, Space.Self);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -Time.deltaTime * 100, 0, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Time.deltaTime * 100, 0, Space.Self);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        touched = true;
    }
    void OnCollisionStay(Collision collision)
    {
        touched = true;
    }
    void OnCollisionExit(Collision collision)
    {
        touched = false;
    }
}
