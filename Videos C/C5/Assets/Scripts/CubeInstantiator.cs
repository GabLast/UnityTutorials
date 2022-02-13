using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startingPos = new Vector3(0, 7.5f);
    public GameObject yellow, red, blue, green;
    float lastTime = 0, nextTime;
    const float MIN_TIME = 1f, MAX_TIME = 1.5f;
    const float MIN_X = -9f, MAX_X = 9f;

    void Start()
    {
        nextTime = GetNextTime();
    }

    // Update is called once per frame
    void Update()
    {
        startingPos.x = Random.Range(MIN_X, MAX_X);
        Instantiate(NextCube(), startingPos, Quaternion.identity);
        nextTime = GetNextTime();
    }

    float GetNextTime()
    {
        return Time.time + Random.Range(MIN_TIME, MAX_TIME);
    }


    GameObject NextCube()
    {
        GameObject cubo;
        switch(Random.Range(0, 3))
        {
            case 0:
                return green;
            case 1:
                return red;
            case 2:
                return blue;
            case 3:
                return yellow;
            default:
                return green;
        }
    }
}
