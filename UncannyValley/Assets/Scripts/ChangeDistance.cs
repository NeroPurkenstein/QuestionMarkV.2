using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDistance : MonoBehaviour
{
    public GameObject EmotionsDisplay;
    private float ZValue= 0.9200001f;
    private Vector3 NewPosition;
    // Start is called before the first frame update
    void Start()
    {
        NewPosition = new Vector3(0.02f, 0.5f, ZValue);
      
    }

   
    public void Closer()
    {
        if (ZValue >= -0.09504139f)
        {
            EmotionsDisplay.transform.Translate(Vector3.back * Time.deltaTime);
           
        }
        else
        {
            Debug.Log("too close");
        }
}
    public void Away()
    {
        //if (ZValue >= 0.9200001f)
        
            EmotionsDisplay.transform.Translate(Vector3.forward * Time.deltaTime);
        
    }

}
