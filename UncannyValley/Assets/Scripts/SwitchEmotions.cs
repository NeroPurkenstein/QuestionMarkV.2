using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEmotions : MonoBehaviour
{
    public GameObject[] emotions;
    private int i = 0;
    private bool isPressed = true;

    //Only one of the emotions is visible
    void Start()
    {
        emotions[0].GetComponent<Renderer>().enabled = true;//SetActive(true);
        for (int x = 1; x <= 4; x++)
        {
            //if (x < emotions.Length)
            //{
                emotions[x].GetComponent<Renderer>().enabled = false;//SetActive(false);
            //}
        }
    }

    //turns off seen emotion and turns the next one visible
    public void Next()
    {
        
        if (isPressed)
        {
            emotions[i].GetComponent<Renderer>().enabled = false; //SetActive(false);
            if (i == 4)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            emotions[i].GetComponent<Renderer>().enabled = true; //SetActive(true);
            isPressed = false;
        }
    }

    //turns off seen emotion and turns the previous one visible
    public void Previous()
    {
        if (isPressed)
        {
            emotions[i].GetComponent<Renderer>().enabled = false;
            if (i == 0)
            {
                i = 4;
            }
            else
            {
                i--;
            }
            emotions[i].GetComponent<Renderer>().enabled = true;
            isPressed = false;
        }
    }
    public void BoolTrue()
    {
        isPressed = true;
    }
}
