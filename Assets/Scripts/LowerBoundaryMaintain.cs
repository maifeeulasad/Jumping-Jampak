using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBoundaryMaintain : MonoBehaviour
{
    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, -5, transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Equals("Player"))
        {
            Debug.Log("Game Over");
        }
    }

}
