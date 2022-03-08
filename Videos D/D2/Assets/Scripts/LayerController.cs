using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{

    float scrollingSpeed = 0.1f, currentSpeed;
    Vector2 currentPos = new Vector2();
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = scrollingSpeed * (20 / gameObject.transform.position.z);
        currentPos.x = currentPos.x + currentSpeed * Time.deltaTime;
        /*currentPos.y = scrollingSpeed * Time.deltaTime + pos.y;*/
        renderer.material.mainTextureOffset = currentPos;
    }
}
