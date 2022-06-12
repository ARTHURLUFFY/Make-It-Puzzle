using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite PlayerStart, PlayerLeft, PlayerRight, PlayerUp, PlayerDown;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = PlayerStart;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rend.sprite = PlayerLeft;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rend.sprite = PlayerRight;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rend.sprite = PlayerUp;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false)
        {
            rend.sprite = PlayerDown;
        }
       if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rend.sprite = PlayerStart;
        }
    }
}
