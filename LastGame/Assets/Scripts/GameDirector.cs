using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject HeartBar;
    GameObject FatBar;

    GameObject Score;

    float Time1 = 1;
    float Time2 = 1;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.HeartBar = GameObject.Find("HeartBar");
        this.FatBar = GameObject.Find("FatBar");

        this.Score = GameObject.Find("Score");
    }
    void Update()
    {
        this.HeartBar.GetComponent<Image>().fillAmount -= 0.0007f;
        this.FatBar.GetComponent<Image>().fillAmount -= 0.0001f;
        if (Time2 < Time.time)
        {
            score += 10;
            Time1 = 1;
            Time2 = Time1 + Time.time;
            this.Score.GetComponent<Text>().text = "score :" + this.score.ToString();
        }
    }

    public void IncreaseHeart()
    {
        this.HeartBar.GetComponent<Image>().fillAmount += 0.1f;
    }
    public void IncreaseFat()
    {
        this.FatBar.GetComponent<Image>().fillAmount += 0.1f;
    }
    public void DecreaseFat()
    {
        this.FatBar.GetComponent<Image>().fillAmount -= 0.01f;
    }
    public void IncreaseBadHeart()
    {
        this.HeartBar.GetComponent<Image>().fillAmount += 0.01f;
    }
}
