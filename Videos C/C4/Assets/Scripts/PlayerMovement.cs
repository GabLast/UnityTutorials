using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    public FloatingJoystick joystick;
    private Vector3 speed = new Vector3(10, 10);
    const float MIN_X = -9, MAX_X = 9, MIN_Y = -4, MAX_Y= 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = joystick.Horizontal * speed.x;
        pos.y = joystick.Vertical * speed.y;
        pos *= Time.deltaTime;
        gameObject.transform.Translate(pos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z);
    }
}
