using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAngry : MonoBehaviour
{
    public GameObject model1;
	 public GameObject model2;
	 public GameObject model3;
	 private GameObject currentModel;
	
	 void Start()
	 {
	     currentModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
	     currentModel.transform.parent = transform;
	 }
	 
	 void Update()
	 {
	     if (Input.GetButtonDown ("Jump")) 
	     {
	         if (currentModel == model1)    
	         {
	             GameObject thisModel = Instantiate(model2, transform.position, transform.rotation) as GameObject;
	             Destroy(currentModel);
	             thisModel.transform.parent = transform;
	             currentModel = thisModel;
	         }
	         else
	         {
	             if (currentModel == model2)
	             {
	                 GameObject thisModel = Instantiate(model3, transform.position, transform.rotation) as GameObject;
	                 Destroy(currentModel);
	                 thisModel.transform.parent = transform;
	                 currentModel = thisModel;
	             }
                 else
	             {
	                 GameObject thisModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
	                 Destroy(currentModel);
                 thisModel.transform.parent = transform;
	                 currentModel = thisModel;
	             }
	         }
	     }
	 }

}
