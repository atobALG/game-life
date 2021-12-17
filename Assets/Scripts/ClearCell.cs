using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCell : MonoBehaviour
{
    public GameObject extraObject;
    public void ClearGrid()
    {
        
    string name = "Cells";

        GameObject go = GameObject.Find(name);
            //if the tree exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + " has been destroyed.");
                
            }
    }

    public void HideExtra()
    {

        Debug.Log("Adios Extra Objects");

        extraObject.SetActive(false);


    }

}
