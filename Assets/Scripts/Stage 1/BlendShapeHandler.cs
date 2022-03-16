using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendShapeHandler : MonoBehaviour
{
    //many 3d models when imported to unity will have different children objects. ObjectToBlend should be the one that has the SkinnedMeshRenderer component
    //but if there is no way of knowing, just put the parent 3d model.
    [SerializeField] private GameObject objectToBlend;
    [SerializeField] private List<BodyPartEnum> bodyPartsWithBlendShapes;

    public List<SkinnedMeshRenderer> meshRenderer;
    private Mesh skinnedMesh;
    private int noOfBlends;
    private List<float> blendShapeValues = new List<float>();
    private StageOneStaticData levelData;


    // This is done in awake because variable in ModelDataController's start depend on these values. 
    void Awake()
    {
        

        meshRenderer = getSkinnedMeshRenderer(objectToBlend);


        foreach (SkinnedMeshRenderer _renderer in meshRenderer)
        {
            skinnedMesh = _renderer.sharedMesh;
            noOfBlends = skinnedMesh.blendShapeCount;
            for (int i = 0; i<noOfBlends; i++)
            {
                blendShapeValues.Add(_renderer.GetBlendShapeWeight(i) );
            } 
        }
            

    }

    void Start()
    {
        levelData = StageOneStaticData.Instance;
    }

    /// <summary>
    /// This function tries to obtain a reference to all SkinnedMeshRenderers in a 3D model object. It first attempts to get it from the base object, but if it's not found it searches in its children
    /// </summary>
    /// <param name="modelObject">
    /// The reference to the base GameObject containing the 3D model. This GameObject or its children should contain a SkinnedMeshRenderer component (found in all 3D models imported to unity) 
    /// </param>
    private List<SkinnedMeshRenderer> getSkinnedMeshRenderer(GameObject modelObject)
    {
            Component[] backupSkinnedMesh;
            List<SkinnedMeshRenderer> skinnedMeshList = new List<SkinnedMeshRenderer>();
            backupSkinnedMesh =  modelObject.GetComponentsInChildren(typeof(SkinnedMeshRenderer));
            if(backupSkinnedMesh.Length > 0)
            {
                foreach (SkinnedMeshRenderer _renderer in backupSkinnedMesh)
                {
                    skinnedMeshList.Add(_renderer);
                }
    
                return skinnedMeshList;
            }

            return null;
    }

    /// <summary>
    /// This function changes the value of the blend shape with index indicated by shapeIndex, to the value specified by shapeValue
    /// </summary>
    /// <param name="shapeIndex">
    /// The index of the blend shape to be changed. Unity does not support blend shape influences 
    /// </param>
    /// <param name="shapeValue">
    /// The new value the blend shape will take. While supported, going above 100 and below 0 can cause graphical glitches.  
    /// </param>
    public void ChangeBlendShape(int shapeIndex, float shapeValue)
    {
        foreach (SkinnedMeshRenderer _renderer in meshRenderer)
        {
            if(_renderer.sharedMesh.blendShapeCount>shapeIndex)
            {
                _renderer.SetBlendShapeWeight(shapeIndex,shapeValue); 
                blendShapeValues[shapeIndex] = shapeValue;
            }
        }
        
    }


    /// <summary>
    /// This function changes the value of the blend shape with index indicated by shapeIndex, to the value specified by shapeValue
    /// </summary>
    /// <param name="shapeIndex">
    /// The index of the blend shape to be changed. Unity does not support blend shape influences 
    /// </param>
    public void ChangeMultipleBlendShapes(int[] shapeIndexes, float shapeValue)
    {
        for (int i = 0; i<shapeIndexes.Length; i++)
        {
            ChangeBlendShape(shapeIndexes[i], shapeValue);
        }
    }

    public void ChangeMultipleBlendShapes(int[] shapeIndexes, float[] shapeValues)
    {
        if(shapeIndexes.Length==shapeValues.Length)
        {
            for (int i = 0; i<shapeIndexes.Length; i++)
            {
                ChangeBlendShape(shapeIndexes[i], shapeValues[i]);
            }
        }
        
    }

    public int getBlendShapeCount()
    {
        return noOfBlends;
    }


    public void UpdateMeshRendererReference(GameObject _mesh)
    {
        BodyPart changedPart = BodyPart.GetPartByMesh(_mesh,levelData.bodyPartListScript.bodyParts);

        
        if(changedPart !=null && bodyPartsWithBlendShapes.Contains(changedPart.name))
        {
            meshRenderer = getSkinnedMeshRenderer(objectToBlend);

            for (int i = 0; i < blendShapeValues.Count; i++)
            {
                ChangeBlendShape(i, blendShapeValues[i]);
            }
        } 
    }

}
