using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureModifier : MonoBehaviour
{
    private Material[] materialsInObject;

    public void UpdateTexture(string _attributeName, GameObject texturedObject, Material _material, Color newColor)
    {
        materialsInObject = texturedObject.GetComponent<Renderer>().materials;

        foreach (Material material in materialsInObject)
        {
            if (material==_material)
            {
                material.SetColor(_attributeName,newColor);
            }
        }
    }

    public void UpdateTexture(string _attributeName, Material _material, float newValue)
    {

    }
}
