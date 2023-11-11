using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherashoot : MonoBehaviour
{
    public Rigidbody sphereRefab;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody sphere = Instantiate(sphereRefab);
            sphere.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            sphere.AddForce(Vector3.back * force);
        }
    }
}
