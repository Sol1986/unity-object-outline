using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineObject : MonoBehaviour
{
    public Material[] materials;
    public GameObject cube;

    public void AddHighlight()
    {
        
        Material[] currentlyAssignedMaterials = GetComponent<Renderer>().materials;
        
        currentlyAssignedMaterials[1] = materials[0];
        GetComponent<Renderer>().materials = currentlyAssignedMaterials;

    }

    public void RemoveHighlight()
    {
        
        Material[] currentlyAssignedMaterials = GetComponent<Renderer>().materials;
        
        currentlyAssignedMaterials[1] = materials[1];
        GetComponent<Renderer>().materials = currentlyAssignedMaterials;

    }

}
