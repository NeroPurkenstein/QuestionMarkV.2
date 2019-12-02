using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmotion : MonoBehaviour
{
    public GameObject[] emotions;
    private int i = 0;

    //Only one of the emotions is visible
    void Start()
    {
        emotions[0].SetActive(true);
     for(int x=1; x<5; x++)
        {
            emotions[x].SetActive(false);
        }
}

    //turns off seen emotion and turns the next one visible
    public void Next()
    {
        emotions[i].SetActive(false);
        if (i == 5)
        {
            i = 0;
        }
        else
        {
            i++;
        }
        emotions[i].SetActive(true);
    }

    //turns off seen emotion and turns the previous one visible
    public void Previous()
    {
        emotions[i].SetActive(false);
        if (i == 0)
        {
            i = 5;
        }
        else
        {
            i--;
        }
        emotions[i].SetActive(true);
    }
}
