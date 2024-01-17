using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f,0f, -10f);
    private float smoothTime = .1f;
    private Vector3 velocity = Vector3.zero;
    public GameObject Camera_1;
    public GameObject Camera_2;
    public int Manager;
    private int loop = 0;
    [SerializeField] private Transform target;

    public void ManageCamera()
    {
        if(Manager == 0)
        {
            Cam_2();
            Manager = 1;
        }
        else
        {
            Cam_1();
            Manager = 0;
        }
    }

    void Cam_1()
    {
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }

    void Cam_2()
    {
        Camera_1.SetActive(false);
        Camera_2.SetActive(true);
    }

    void Start()
    {
        ManageCamera();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position,newPosition, ref velocity, smoothTime);
        if (target.position.y > 80)
        {
            Manager = 0;
            ManageCamera();
            loop += 1;
            if (loop > 15)
            {
                Time.timeScale = 0;
            }
        }
    }
}
