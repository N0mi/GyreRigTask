using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public float Speed { get; set; }
    public float Distance { get; set; }

    private void Update()
    {
        Vector3 oldPos = transform.position;
        Move();
        Distance -= Mathf.Abs((oldPos - transform.position).magnitude);

        if(Distance < 0)
        {
            Death();
        }
    }

    private void Move()
    {
        transform.Translate(-transform.forward * Time.deltaTime * Speed);
    }

    private void Death()
    {
        Destroy(this.gameObject);
    }
}
