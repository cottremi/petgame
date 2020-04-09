// ADAPTED FROM TUTORIAL: https://www.youtube.com/watch?v=EANtTI6BCxk 

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public string objectBeingPet = "none";

    void Start()
    {
       
    }
    
    void Update()
    {
        
        if (Input.GetMouseButton(0)) {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.transform != null)
                {
                    //PrintName(hit.transform.gameObject);
                    objectBeingPet = (hit.transform.gameObject.name);
                    print(objectBeingPet);
              
                } 
            }
	    }

        if (Input.GetMouseButtonUp(0))
        {
            objectBeingPet = "none";
            print(objectBeingPet);
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
