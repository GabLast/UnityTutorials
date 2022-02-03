using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;
    private string scoreString = "Score: ";
    public TextMesh scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreString + currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        currentScore++;
        scoreText.text = scoreString + currentScore.ToString();
    }
}
