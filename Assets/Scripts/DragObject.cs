// TUTORIAL: https://www.youtube.com/watch?time_continue=33&v=0yHBDZHLRbQ&feature=emb_logo (actually he just gives you the script, it's nice)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

   //sets the "Material Editor" script as variable
    private MaterialEditor materialEditorScript;
    private bool berryIsPickedUp; 

    
    //calls to the "Material Editor" script
    void Awake()
    {
        materialEditorScript = GameObject.FindObjectOfType<MaterialEditor>();

    }


    void OnMouseDown()
    {

        //sets a boolean that "Material Editor" script can use so it knows when you picked up the berry
        berryIsPickedUp = true;

        mZCoord = Camera.main.WorldToScreenPoint(
            gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
   

    }

    
    // from tutorial
    private Vector3 GetMouseAsWorldPoint()
    {

        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    { 
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }


   // destorys the game object this script is attached to (the berry) when its collider enters the collider on an object with the tag "Destory" 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }


    ////sends variable to the "MaterialEditor" script
    private void Update()
    {
        
        materialEditorScript.updateDragObjecrForMaterialEditor(berryIsPickedUp);
    }
}
