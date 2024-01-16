using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject circle;
    public float time = 0f;
    public float timeDelay = 2f;
    private int RadNum;

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
            RadNum = Random.Range(1,6);
            Vector2 randPos = new Vector2(Random.Range(-8,8),80);
            if (RadNum == 1)
            { 
                Instantiate(cube,randPos,Quaternion.identity);
            }
            else if (RadNum == 2)
            {
                Instantiate(cube2,randPos,Quaternion.identity);
            }
            else if (RadNum == 3)
            {
                Instantiate(cube3,randPos,Quaternion.identity);
            }
            else if (RadNum == 4)
            {
                Instantiate(cube4,randPos,Quaternion.identity);
            }
            else
            {
                Instantiate(circle,randPos,Quaternion.identity);
            }
        }
    }
}
