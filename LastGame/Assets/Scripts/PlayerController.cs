using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Vector2 move;
    public Sprite healthy;
    public Sprite fat;
    public Sprite hungry;
    private SpriteRenderer spriteRenderer;

    GameObject HeartBar;
    GameObject FatBar;

    // Start is called before the first frame update
    void Start()
    {
        this.HeartBar = GameObject.Find("HeartBar");
        this.FatBar = GameObject.Find("FatBar");

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = healthy;
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x -= 10f;
            transform.localScale = new Vector3(-0.6f, 0.6f, 0.6f);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x += 10f;
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }

        GetComponent<Rigidbody2D>().velocity = move;

        if (this.FatBar.GetComponent<Image>().fillAmount >= 0.6f)
        {
            spriteRenderer.sprite = fat;
        }

        if ((this.FatBar.GetComponent<Image>().fillAmount < 0.6f) && this.HeartBar.GetComponent<Image>().fillAmount > 0.3f)
        {
            spriteRenderer.sprite = healthy;
        }

        if ((this.HeartBar.GetComponent<Image>().fillAmount <= 0.3f))
        {
            spriteRenderer.sprite = hungry;
        }

        if((this.HeartBar.GetComponent<Image>().fillAmount == 0.0f))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().GameOver();
        }

        if ((this.FatBar.GetComponent<Image>().fillAmount >= 0.99f))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().GameOver();
        }
    }
}
