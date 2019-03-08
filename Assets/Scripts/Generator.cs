using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Generator : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        StartCoroutine(Create());
    }

    void Update()
    {

    }


    IEnumerator Create()
    {
        int i = 18;
        while (true)
        {
            GameObject tem = Instantiate(cube, new Vector3(i, Random.Range(-0.5f,0.5f), 0), Quaternion.identity);
            tem.transform.parent = gameObject.transform;
            i += 6;
            yield return new WaitForSeconds(0.5f);
        }
    }

}
