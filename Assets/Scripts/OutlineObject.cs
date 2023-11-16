using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineObjectController : MonoBehaviour
{
    public Material[] materials;
    public GameObject cube;

    public void AddHighlight()
    {
        
        Material[] currentlyAssignedMaterials = cube.GetComponent<Renderer>().materials;
        
        currentlyAssignedMaterials[1] = materials[0];
        cube.GetComponent<Renderer>().materials = currentlyAssignedMaterials;

    }

    public void RemoveHighlight()
    {
        
        Material[] currentlyAssignedMaterials = cube.GetComponent<Renderer>().materials;
        
        currentlyAssignedMaterials[1] = materials[1];
        cube.GetComponent<Renderer>().materials = currentlyAssignedMaterials;

    }

}
