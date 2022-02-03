using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float speedY = 20f;
    private Vector3 deltaPos = new Vector3();
    private const float maxLimitY = 4.25f;
    private const float minLimitY = -4.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaPos.y = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            Mathf.Clamp(gameObject.transform.position.y, minLimitY, maxLimitY),
            gameObject.transform.position.z);
    }
}
