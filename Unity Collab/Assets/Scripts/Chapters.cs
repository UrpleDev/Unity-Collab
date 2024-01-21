using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapters : MonoBehaviour
{
    public GameObject world1;
    public GameObject chapter1;

    void Start()
    {
        chapter1.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            world1.SetActive(false);
            chapter1.SetActive(true);
        }
    }
}
