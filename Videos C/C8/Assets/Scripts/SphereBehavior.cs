using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    Vector3 deltaPos = new Vector3();
    Vector3 currentSpeed = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //  Yf = Yi + Viy * (a * T^2)/2
        deltaPos.y = currentSpeed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime, 2) / 2;
        gameObject.transform.Translate(deltaPos);
        currentSpeed += Physics.gravity * Time.deltaTime;
    }
}
