using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreate : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        GameObject tem = Instantiate(gameObject, transform.position + new Vector3(18, Random.Range(-0.5f, 0.5f), 0), transform.rotation);
        tem.transform.parent = gameObject.transform.parent;
        if(gameObject.transform.parent.childCount>6)
        {
            Destroy(gameObject.transform.parent.GetChild(0).gameObject);
        }
    }

}
