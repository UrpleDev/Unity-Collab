using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidSpawner : MonoBehaviour
{
    public GameObject David;
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Instantiate(David,transform.position,Quaternion.identity);
    }
}
