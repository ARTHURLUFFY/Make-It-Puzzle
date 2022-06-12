using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public GameObject PlayerStart, PlayerLeft, PlayerRight, PlayerUp, PlayerDown;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStart.gameObject.SetActive(true);
        PlayerLeft.gameObject.SetActive(false);
        PlayerRight.gameObject.SetActive(false);
        PlayerUp.gameObject.SetActive(false);
        PlayerDown.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerStart.gameObject.SetActive(false);
            PlayerLeft.gameObject.SetActive(true);
            PlayerRight.gameObject.SetActive(false);
            PlayerUp.gameObject.SetActive(false);
            PlayerDown.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerStart.gameObject.SetActive(false);
            PlayerLeft.gameObject.SetActive(false);
            PlayerRight.gameObject.SetActive(true);
            PlayerUp.gameObject.SetActive(false);
            PlayerDown.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayerStart.gameObject.SetActive(false);
            PlayerLeft.gameObject.SetActive(false);
            PlayerRight.gameObject.SetActive(false);
            PlayerUp.gameObject.SetActive(true);
            PlayerDown.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerStart.gameObject.SetActive(false);
            PlayerLeft.gameObject.SetActive(false);
            PlayerRight.gameObject.SetActive(false);
            PlayerUp.gameObject.SetActive(false);
            PlayerDown.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            PlayerStart.gameObject.SetActive(true);
            PlayerLeft.gameObject.SetActive(false);
            PlayerRight.gameObject.SetActive(false);
            PlayerUp.gameObject.SetActive(false);
            PlayerDown.gameObject.SetActive(false);
        }
    }
}
