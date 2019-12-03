using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDistance : MonoBehaviour
{
    public GameObject EmotionsDisplay;
    public float nearPosition = -0.09504139f;
    public float farPosition = 10f;

    private Vector3 NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        NewPosition = EmotionsDisplay.transform.position;
        EmotionsDisplay.transform.position = NewPosition;
    }

   
    public void Closer()
    {
        NewPosition.z -= Time.deltaTime;
        NewPosition.z = Mathf.Clamp(NewPosition.z, nearPosition, farPosition);
        EmotionsDisplay.transform.position = NewPosition;
        //Debug.Log("closer");
        //if (ZValue >= -0.09504139f)
        //{
        //    EmotionsDisplay.transform.Translate(Vector3.back * Time.deltaTime);

        //}
        //else
        //{
        //    Debug.Log("too close");
        //}
    }
    public void Away()
    {
        NewPosition.z += Time.deltaTime;
        NewPosition.z = Mathf.Clamp(NewPosition.z, nearPosition, farPosition);
        EmotionsDisplay.transform.position = NewPosition;
        //Debug.Log("away");
        ////if (ZValue >= 0.9200001f)

        //EmotionsDisplay.transform.Translate(Vector3.forward * Time.deltaTime);

    }

}
