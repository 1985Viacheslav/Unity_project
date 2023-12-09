using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Transform trapObject;
    public float offsetPosX;
    public float offsetPosZ;

    // Start is called before the first frame update
    void Start()
    {
        trapObject.transform.position = transform.position + new Vector3(Random.Range(-offsetPosX, offsetPosX), 0, Random.Range(-offsetPosZ, offsetPosZ));
        trapObject.transform.rotation = Quaternion.Euler(Vector3.up *  (trapObject.transform.eulerAngles.y + Random.Range(-15f, 15f)));

        FindObjectOfType<CarScore>().maxScore += 1;
    }
}
