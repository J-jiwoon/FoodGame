using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("health");
    }
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < 95f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.2f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHeart();
            director.GetComponent<GameDirector>().DecreaseFat();
            Destroy(gameObject);
        }
    }
}
