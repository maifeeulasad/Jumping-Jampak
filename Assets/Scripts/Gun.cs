using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightAlt))
        {
            GameObject bulletClone = Instantiate(bullet, transform.position+new Vector3(0,0.5f,1.3f), transform.rotation);
            bulletClone .GetComponent<Rigidbody>().velocity = bulletClone.transform.up * 10;
            bulletClone.transform.parent = null;

            
        }
    }
}
