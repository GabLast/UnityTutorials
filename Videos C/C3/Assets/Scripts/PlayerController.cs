using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speedY = 3;
    Vector3 pos = new Vector3();
    const float MIN_LIMIT = -4, MAX_LIMIT = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.y = Input.touchSupported && Input.touchCount > 0 ? /*Input.touches(*/Input.GetTouch(0).position.y : 0;
        pos.y *= speedY;
        pos *= Time.deltaTime;
        gameObject.transform.Translate(pos);
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIMIT, MAX_LIMIT),
            gameObject.transform.position.z
            );
    }
}
