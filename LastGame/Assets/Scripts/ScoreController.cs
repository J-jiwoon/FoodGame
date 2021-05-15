using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    float Time1 = 1;
    float Time2 = 1;
    int score = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text="score : "+score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time2 < Time.time)
        {
            score += 10;
            Time1 = 1;
            Time2 = Time1 + Time.time;
            scoreText.text="score : "+score.ToString();
        }
    }
}
