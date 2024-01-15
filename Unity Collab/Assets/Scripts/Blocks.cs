using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject cube;
    public float time = 0f;
    public float timeDelay = 2f;

    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (time >= timeDelay)
        {
            time = 0f;
            timeDelay -= .1f;
            if (timeDelay < .5)
            {
                timeDelay += .1f;
            }
            Instantiate(cube,transform.position,Quaternion.identity);
        }
    }
}
