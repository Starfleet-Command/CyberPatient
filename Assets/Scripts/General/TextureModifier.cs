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
    public static void CopyTextures(GameObject target,List<Material> materialsToCopy)
    {
        List<Material> uniqueMaterialsInObject = MaterialUtilities.getAllMaterialsFromObject(target);
        
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
    /// The index of the material to be changed, in the array of materials held in the object. This argument is automatically found when called from AvatarUpdater.
    /// </param>
    /// <param name="newColor">
    /// The new color that the attribute will change to.
    /// </param>
    public void UpdateTexture(string _attributeName, GameObject texturedObject, Color newColor)
    {
        List<Material> uniqueMaterialsInObject = MaterialUtilities.getAllMaterialsFromObject(texturedObject);

        foreach (Material uniqueMaterial in uniqueMaterialsInObject)
        {
            if(uniqueMaterial.HasProperty(_attributeName))
            {
                uniqueMaterial.SetColor(_attributeName,newColor);
            }
        }
        

    }

    public static void UpdateStageTwoTexture(string _attributeName, GameObject texturedObject, Color newColor)
    {
        List<Material> uniqueMaterialsInObject = MaterialUtilities.getAllMaterialsFromObject(texturedObject);

        foreach (Material uniqueMaterial in uniqueMaterialsInObject)
        {
            if(uniqueMaterial.HasProperty(_attributeName))
            {
                uniqueMaterial.SetColor(_attributeName,newColor);
            }
        }
        

    }
    public static void UpdateTextureBool(string _attributeName, GameObject texturedObject, bool isAttributeActive)
    {
        List<Material> uniqueMaterialsInObject = MaterialUtilities.getAllMaterialsFromObject(texturedObject);

        foreach (Material uniqueMaterial in uniqueMaterialsInObject)
        {
            if(uniqueMaterial.HasProperty(_attributeName))
            {
                if(isAttributeActive)
                    uniqueMaterial.SetFloat(_attributeName,1.0f);
                else
                    uniqueMaterial.SetFloat(_attributeName,0.0f);
            }
        }
        
    }

    public static void UpdateTextureFloat(string _attributeName, GameObject texturedObject, float newValue)
    {
        List<Material> uniqueMaterialsInObject = MaterialUtilities.getAllMaterialsFromObject(texturedObject);

        foreach (Material uniqueMaterial in uniqueMaterialsInObject)
        {
            if(uniqueMaterial.HasProperty(_attributeName))
            {
                uniqueMaterial.SetFloat(_attributeName,newValue);
            }
        }
        
        
    }
}
