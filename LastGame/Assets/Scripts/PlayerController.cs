using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x -= 7f;
            transform.localScale = new Vector3(-0.6f, 0.6f, 0.6f);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x += 7f;
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        }

        GetComponent<Rigidbody2D>().velocity = move;
    }
}
