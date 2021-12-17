using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : Cell
{
    // Start is called before the first frame update
    public void ChangeIt()
    {
        if (state == States.Alive)
            meshRenderer.sharedMaterial = changedMaterial;

        // gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    private MeshRenderer meshRenderer;

    public Material livingMaterial;
    public Material deadMaterial;

    public Material changedMaterial;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public override void UpdateLook()
    {
        if (state == States.Alive)
            meshRenderer.sharedMaterial = livingMaterial;
        else
            meshRenderer.sharedMaterial = deadMaterial;
    }



}
