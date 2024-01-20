using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private float timer = 0;
    private float rand;

    void Update()
    {
        if (timer > rand)
        {
            Instantiate(Enemy,transform.position,Quaternion.identity);
            timer = 0;
            rand = Random.Range(2000,4500);
        }

        timer += 1f;
    }
}
