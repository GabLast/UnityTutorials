using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector3 currentPos = new Vector3();
    const float MAXY = 8f, MINY = -4f, speedY = 20; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPos.y = MINY + Mathf.PingPong(Time.time * speedY, MAXY);
        gameObject.transform.position = currentPos;
    }
}
