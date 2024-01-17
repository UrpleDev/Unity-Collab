using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    private bool isFloating = false;
    private float timer = 0;
    private float originalPos = 0;



    void Start()
    {
        originalPos = transform.position.y;
    }

    void Update()
    {
        if (isFloating == false)
        {
            timer += .0005f;
            transform.position = new Vector2(transform.position.x,timer+originalPos);
            if (transform.position.y > .2+originalPos)
            {
                timer -= .0003f;
            }
            if (transform.position.y > .25+originalPos)
            {
                isFloating = true;
            }
        }
        else
        {
            timer -= .0005f;
            transform.position = new Vector2(transform.position.x,timer+originalPos);
            if (transform.position.y < -.2+originalPos)
            {
                timer += .0003f;
            }
            if (transform.position.y < -.25+originalPos)
            {
                isFloating = false;
            }
        }
    }
}
