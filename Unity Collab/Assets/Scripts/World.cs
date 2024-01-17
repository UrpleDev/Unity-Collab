using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{

    public float world = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            world = world-1;
        }
        if (Input.GetKeyDown("right"))
        {
            world = world+1;
        }
    }
}
