using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shield;
    const float shieldRadius = 3f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(shield, gameObject.transform.position, Quaternion.identity).GetComponent<MovCircularUniformementeVariado>().Shoot(gameObject, shieldRadius);
        }
    }
}
