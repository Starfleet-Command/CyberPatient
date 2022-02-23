using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureModifier : MonoBehaviour
{
    
    /// <summary>
    /// This function copies all the properties from a list of materials and applies it to the materials present in the target. This should only be called when the shader in 
    /// both the target and the source materials are the same.
    /// </summary>
    /// <param name="target">
    /// The game object holding the textures that will have changes applied to them.
    /// </param>
    /// <param name="materialsToCopy">
    /// The materials that will provide their properties to be copied to the target.
    /// </param>
    public void CopyTextures(GameObject target,List<Material> materialsToCopy)
    {
        List<Material> uniqueMaterialsInObject = getAllMaterialsFromObject(target);

        //Preventing compatibility errors if there is a mismatch in the number of materials in either side.
        for (int i = 0; i < Mathf.Min(uniqueMaterialsInObject.Count,materialsToCopy.Count); i++)
        {
            uniqueMaterialsInObject[i].CopyPropertiesFromMaterial(materialsToCopy[i]); 
        }
    }


    /// <summary>
    /// This function changes the color of a specific color attribute in a specific material located in a certain object.
    /// </summary>
    /// <param name="_attributeName">
    /// the name of the shader attribute to change.
    /// </param>
    /// <param name="texturedObject">
    /// The object that will have its material changed. 
    /// </param>
    /// <param name="indexOfMaterial">
    /// The index of the material to be changed, in the array of materials held in the object. This argument is automatically found when called from UI_Orchestrator.
    /// </param>
    /// <param name="newColor">
    /// The new color that the attribute will change to.
    /// </param>
    public void UpdateTexture(string _attributeName, GameObject texturedObject, int indexOfMaterial, Color newColor)
    {
        List<Material> uniqueMaterialsInObject = getAllMaterialsFromObject(texturedObject);
        
        uniqueMaterialsInObject[indexOfMaterial].SetColor(_attributeName,newColor);
        

    }

    /// <summary>
    /// This function gets all the instanced materials present in the parentObject and its children
    /// </summary>
    /// <param name="parentObject">
    /// The object to be searched for materials.
    /// </param>
    /// <returns>
    /// The list of all materials present in the object and children, in hierarchical order.
    /// </returns>
    public List<Material> getAllMaterialsFromObject(GameObject parentObject)
    {
        Renderer parentObjectRenderer;
        List<Material> uniqueMaterialsInObject = new List<Material>();

        if(parentObject.TryGetComponent<Renderer>(out parentObjectRenderer))
        {
            foreach (Material item in parentObjectRenderer.materials)
                {
                    uniqueMaterialsInObject.Add(item);
                } 
        }
        
        if(parentObject.transform.childCount>0)
        {
            Renderer[] allChildRenderers = parentObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer childRenderer in allChildRenderers)
            {
                foreach (Material item in childRenderer.materials)
                    {
                        if(!uniqueMaterialsInObject.Contains(item))
                            uniqueMaterialsInObject.Add(item);
                    }  
            }
        }
        

        return uniqueMaterialsInObject;
       
    }

    /// <summary>
    /// This function gets all the non-unique materials present in the parentObject and its children
    /// </summary>
    /// <param name="parentObject">
    /// The object to be searched for materials.
    /// </param>
    /// <returns>
    /// The list of all materials present in the object and children, in hierarchical order.
    /// </returns>
    public List<Material> getAllSharedMaterialsFromObject(GameObject parentObject)
    {
        Renderer parentObjectRenderer;
        List<Material> uniqueMaterialsInObject = new List<Material>();

        if(parentObject.TryGetComponent<Renderer>(out parentObjectRenderer))
        {
            foreach (Material item in parentObjectRenderer.sharedMaterials)
                {
                    uniqueMaterialsInObject.Add(item);
                } 
        }
        
        if(parentObject.transform.childCount>0)
        {
            Renderer[] allChildRenderers = parentObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer childRenderer in allChildRenderers)
            {
                foreach (Material item in childRenderer.sharedMaterials)
                    {
                        if(!uniqueMaterialsInObject.Contains(item))
                            uniqueMaterialsInObject.Add(item);
                    }  
            }
        }

        return uniqueMaterialsInObject;
       
    }
}
