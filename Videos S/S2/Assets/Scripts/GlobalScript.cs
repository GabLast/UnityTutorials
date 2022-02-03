using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManagerHolder").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            scoreManager.IncrementScore();
        }
    }
}
