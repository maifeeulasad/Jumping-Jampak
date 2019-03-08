using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    public Material[] materials = new Material[4];
    
    

    void Start()
    {
        StartCoroutine(ChangeColor());
    }


    IEnumerator ChangeColor()
    {
        while(true)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[(int)Random.Range(0, 4)];
            yield return new WaitForSeconds(2.5f);
        }
    }

}
