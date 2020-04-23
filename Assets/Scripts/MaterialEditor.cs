using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MaterialEditor : MonoBehaviour
{

    MeshRenderer meshRenderer;
    public Texture Texture1;
    public Texture Texture2;
    public Texture Texture3;

    private string test;

  ////gets the variable named "mouseObject" from the script "MouseInput" and is updated every frame because the MouseInput script is calling to this script in the Update function
    public void updateMouseInputForMaterialEditor(string mouseObject)
    {
        test = mouseObject;
        //print("AAAA" + test);

       
        ////sets the texture to the OWO picture (and sets it back after the mouse isn't over the "CubeParent"
        meshRenderer = GetComponent<MeshRenderer>();

       
        //if the mouse is over or clicking anything but the "BerryParent" object the cubes face texture will be "OWO" 
        if (mouseObject != "BerryParent")
        {
            meshRenderer.material.SetTexture("_MainTex", Texture1);
        }
        

       //sets the texture to the UWU if the mouse is clicked and over the "CubeParent" object
        if (mouseObject == "CubeParent")
        {
            meshRenderer.material.SetTexture("_MainTex", Texture2);
        }
    }

   
    //changes the cube's texture to the "OAO" texture when you are "holidng" the berry (clicking and dragging the berry) 
    public void updateDragObjecrForMaterialEditor(bool berryIsPickedUp)
    {

        print(berryIsPickedUp);

        if (berryIsPickedUp == true)
        {
            meshRenderer.material.SetTexture("_MainTex", Texture3);
           
        }
    }


        // Start is called before the first frame update
        void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //meshRenderer = GetComponent<MeshRenderer>();
       // meshRenderer.material.SetTexture("_MainTex", albedoTexture1);
    }
}
