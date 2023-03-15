using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Vector3 TargetPos;

    private void Start()
    {
        TargetPos = transform.position;
    }

    private void Update()
    {
        var step = _speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, TargetPos, step);
    }
}
