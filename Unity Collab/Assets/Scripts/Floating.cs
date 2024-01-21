using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Floating : MonoBehaviour
{
    private bool isFloating = false;
    private float timer = 0;
    private float originalPos = 0;
    public UnityEvent buttonClick;
    public GameObject b;
    public GameObject world1;

    void Start()
    {
        originalPos = transform.position.y;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            buttonClick.Invoke();
            Debug.Log("Hallo");
            world1.SetActive(true);
            b.SetActive(false);

        }   

        if (isFloating == false)
        {
            timer += .05f;
            transform.position = new Vector2(transform.position.x,timer+originalPos);
            if (transform.position.y > 20+originalPos)
            {
                timer -= .025f;
            }
            if (transform.position.y > 23+originalPos)
            {
                timer -= .01f;
            }
            if (transform.position.y > 24+originalPos)
            {
                timer -= .005f;
            }
            if (transform.position.y > 25+originalPos)
            {
                isFloating = true;
            }
        }
        else
        {
            timer -= .05f;
            transform.position = new Vector2(transform.position.x,timer+originalPos);
            if (transform.position.y < -20+originalPos)
            {
                timer += .025f;
            }
            if (transform.position.y < -23+originalPos)
            {
                timer += .01f;
            }
            if (transform.position.y < -24+originalPos)
            {
                timer += .005f;
            }
            if (transform.position.y < -25+originalPos)
            {
                isFloating = false;
            }
        }
    }
}
