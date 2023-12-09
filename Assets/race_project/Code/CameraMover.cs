using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = target.position - transform.position;
    }

    private void FixedUpdate()
    {
        if(target != null)
        {
            transform.position = target.position - _offset;
            transform.rotation = Quaternion.Euler(Vector3.up * target.eulerAngles.y);
        }
    }
}
