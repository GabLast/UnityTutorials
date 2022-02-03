using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    public WebAPIClient webAPIClient;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            webAPIClient.SendScore("unity jugador", 99);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            webAPIClient.GetScores();
        }
    }
}
