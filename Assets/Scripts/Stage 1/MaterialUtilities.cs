using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialUtilities : MonoBehaviour
{
    /// <summary>
    /// This function gets all the instanced materials present in the parentObject and its children
    /// </summary>
    /// <param name="parentObject">
    /// The object to be searched for materials.
    /// </param>
    /// <returns>
    /// The list of all materials present in the object and children, in hierarchical order.
    /// </returns>
    public static List<Material> getAllMaterialsFromObject(GameObject parentObject)
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
    public static List<Material> getAllSharedMaterialsFromObject(GameObject parentObject)
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
