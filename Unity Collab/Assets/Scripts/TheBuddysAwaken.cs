using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBuddysAwaken : MonoBehaviour
{
    
    public GameObject chapter1;
    public GameObject screen;
    public GameObject levels;

    void Start()
    {
        levels.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            levels.SetActive(true);
            screen.SetActive(false);
            chapter1.SetActive(false);
        }
    }
}
