using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Davidmove : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector2(12,-1);
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x-.002f,transform.position.y);
        
        if (transform.position.x < -4)
        {
            Destroy(this);
        }
    }

}
