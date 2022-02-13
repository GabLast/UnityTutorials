using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{

    float scrollingSpeed = 0.2f, currentSpeed;
    Vector2 pos = new Vector2();
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
        pos.x = currentSpeed * Time.deltaTime + pos.x;
        /*pos.y = scrollingSpeed * Time.deltaTime + pos.y;*/
        renderer.material.mainTextureOffset = pos;
    }
}
