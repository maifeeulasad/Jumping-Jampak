using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperPlayerControl : MonoBehaviour
{

    bool touched = false;

    int forwardSpeed = 5;

    

    void Update()
    {
        if (touched)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody>().AddForce((Vector3.up * 1.2f + gameObject.transform.right) * 250);
            }

            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(gameObject.transform.right * Time.deltaTime * forwardSpeed, Space.Self);
            }
            
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

