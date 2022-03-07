using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject munition;
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 20f;
    float currentAngle;
    float deltaX, deltaY;
    Vector3 userInput;

    // Start is called before the first frame update
    void Start()
    {
        userInput = new Vector3();
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        /*userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);*/


        if (Input.GetButtonDown("Fire1") /*o Input.GetMouseButtonDown(0)*/)
        {
            userInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            deltaY = userInput.y - gameObject.transform.position.y;
            deltaX = userInput.x - gameObject.transform.position.x;
            currentAngle = Mathf.Atan(deltaY / deltaX);
            Debug.Log(currentAngle * Mathf.Rad2Deg);
            
            Instantiate(munition, gameObject.transform.position, Quaternion.identity).GetComponent<TiroParabolico>().Shoot(startingSpeed, currentAngle);
        }

        
        

    }
}
