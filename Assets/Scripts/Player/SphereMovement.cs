using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public static Vector3 TargetPos;
    void Start()
    {
        TargetPos = transform.position;
    }

    void Update()
    {
        float dist = Vector3.Distance(TargetPos, transform.position);
        if (dist > 1)
        {
            Vector3 NeedPos = (TargetPos - transform.position) / (dist * 20);
            transform.position += NeedPos;
            //Debug.LogError(transform.position);
        }
    }
}
