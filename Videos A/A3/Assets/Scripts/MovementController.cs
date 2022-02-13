using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Animator currentAnimator;
    float maxWalkingSpeed = 8f, maxRunningSpeed = 15f, currentSpeed;
    Vector3 deltaPos = new Vector3();
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        currentAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentAnimator.SetBool("isAttacking", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            currentAnimator.SetBool("isAttacking", false);
        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunningSpeed : maxWalkingSpeed);
        deltaPos.x = Time.deltaTime * currentSpeed;

        currentAnimator.SetFloat("speed", Mathf.Abs(currentSpeed));

        /* if (currentSpeed < 0)
         {
             sprite.flipX = true;
         }*/
        sprite.flipX = currentSpeed < 0;

        gameObject.transform.Translate(deltaPos); 

    }
}
