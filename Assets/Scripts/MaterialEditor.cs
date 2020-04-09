using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MaterialEditor : MonoBehaviour
{

    MeshRenderer meshRenderer;
    public Texture albedoTexture1;
    public Texture albedoTexture2;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.SetTexture("_MainTex", albedoTexture1);
    }
}
