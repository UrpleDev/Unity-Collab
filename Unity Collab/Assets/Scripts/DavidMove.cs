using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Davidmove : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
        transform.position = new Vector2(transform.position.x+14,transform.position.y+2);
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x-.02f,-1);

        if (transform.position.x < -4)
        {
            Destroy(this);
        }
    }

}
