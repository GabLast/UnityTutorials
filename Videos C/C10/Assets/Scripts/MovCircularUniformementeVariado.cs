using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCircularUniformementeVariado : MonoBehaviour
{
    GameObject centerObject;
    Vector3 currentPos = new Vector3(), angle, currentSpeed = new Vector3(/*10,10*/);
    float currentDistance, scalarAcceleration = 5f, shootingTime;
    //cambiando la aceleracion a 0 hace que se vuelva constante.
    // Update is called once per frame
    void Update()
    {
        angle = currentSpeed * (Time.time - shootingTime) / currentDistance;

        //si sumo el sin o cos o ambos, pasan cosas interesantes
        currentPos.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPos.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        gameObject.transform.position = currentPos;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
    }

    public void Shoot(GameObject center, float radio)
    {
        centerObject = center;
        currentDistance = radio;
        shootingTime = Time.time;
    }
}
