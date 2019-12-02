using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDistance : MonoBehaviour
{
    public GameObject EmotionsDisplay;
    float ZValue= 0.9200001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Closer()
    {
        //if (ZValue <= -0.249f)
        
            EmotionsDisplay.transform.Translate(Vector3.back * Time.deltaTime);
        
}
    public void Away()
    {
        //if (ZValue >= 0.9200001f)
        
            EmotionsDisplay.transform.Translate(Vector3.forward * Time.deltaTime);
        
    }
}
