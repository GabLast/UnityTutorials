using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallImpulse : MonoBehaviour
{
    float startingForce = 500f;
    bool hasStarted = false;
    Rigidbody rigidbody;
    Vector3 force = new Vector3(1,1);
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted && Input.GetButtonDown("Fire1"))
        {
            hasStarted = true;
            force *= startingForce;
            rigidbody.AddForce(force);
        }
    }
}
