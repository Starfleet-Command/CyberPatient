using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BodyPartModelReference : MonoBehaviour
{
    [SerializeField] private GameObject objectToExtractFrom;
    public List<BodyPart> initialModelParts = new List<BodyPart>();
    public List<HeightBone> heightBones = new List<HeightBone>();
    private StageOneStaticData levelData;

    
    [ContextMenu("Fill Part List")]
    public void FillInitialPartList()
    {
        initialModelParts.Clear();
        foreach (Transform child in objectToExtractFrom.GetComponentsInChildren<Transform>())
        {
            foreach(BodyPartEnum partName in Enum.GetValues(typeof(BodyPartEnum)))
            {
                if(child.gameObject.name == partName.ToString())
                {
                    initialModelParts.Add(new BodyPart(partName,child.gameObject,MaterialUtilities.getAllSharedMaterialsFromObject(child.gameObject),ReturnFirstActiveObject(child.gameObject)));
                    
                }
            }
            
        }
    }

    private GameObject ReturnFirstActiveObject(GameObject parent)
    {
        foreach (Transform child in parent.GetComponentsInChildren<Transform>())
        {
            if(child.gameObject != parent && child.gameObject.activeSelf)
            {
                return child.gameObject;
            }
        }
        
        return null;
    }

    private void Start()
    {
        levelData = StageOneStaticData.Instance;
        if(levelData!= null)
        {
            levelData.bodyPartListScript.SetPartLists(initialModelParts,heightBones);
        }
    }
}

[System.Serializable]
public class HeightBone
{
    public GameObject boneObject;
    public Vector3 scaleModifier;
    public Vector3 originalScale;
}
