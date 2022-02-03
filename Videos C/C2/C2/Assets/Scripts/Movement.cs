using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 movSpeed = new Vector3(20, 20);
    private Vector3 deltaPos = new Vector3();
    private const float maxLimitY = 4.25f;
    private const float minLimitY = -4.25f;
    private const float maxLimitX = 8.20f;
    private const float minLimitX = -8.20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * movSpeed.y;
        deltaPos.y = Input.GetAxis("Vertical") * movSpeed.y;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, minLimitX, maxLimitX),
            Mathf.Clamp(gameObject.transform.position.y, minLimitY, maxLimitY),
            gameObject.transform.position.z);
    }
}
