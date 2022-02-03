using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollComtroller : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    private float scrollSpeed = 0.3f;
    private Vector2 currentPos = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPos.x += scrollSpeed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = currentPos;
    }
}
