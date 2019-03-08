using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{


    public Transform playerToFollow;
    
    void Start()
    {
        playerToFollow = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(playerToFollow.transform.position.x, playerToFollow.transform.position.y, transform.position.y/3  -10);
 
        
    }

}
