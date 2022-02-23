using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartRepository : MonoBehaviour
{
    public List<BodyPart> bodyParts = new List<BodyPart>();
    public List<BodyPart> initialBodyParts = new List<BodyPart>();
    private StageOneStaticData levelData;

    //The following 2 functions add and remove a subscriber to the event that is fired when a new mesh is selected by the user.
     private void OnEnable()
    {
        StageOneEventManager.OnMeshChanged+=UpdateBodyMeshReference;
    }

    private void OnDisable()
    {
        StageOneEventManager.OnMeshChanged-=UpdateBodyMeshReference;
    }

    private void Start()
    {
        levelData = StageOneStaticData.Instance;
    }

    /// <summary>
    /// This function triggers when the mesh is changed, and updates the reference of the body part the previous mesh was linked with to the new mesh.
    /// </summary>
    /// <param name="_mesh">
    /// The reference to the new mesh that has been added in.
    /// </param>
    public void UpdateBodyMeshReference(GameObject _mesh)
    {
        foreach (BodyPart part in bodyParts)
        {
            if(_mesh.transform.parent.gameObject == part.bodyPartParent)
            {
                Destroy(part.bodyPartMesh);
                part.bodyPartMesh = _mesh;
                part.bodyPartMaterial.Clear();

                part.bodyPartMaterial= levelData.textureModifierScript.getAllSharedMaterialsFromObject(_mesh);
                
            }
 
        }
        
    }

    /// <summary>
    /// This function returns all body parts and textures to the state described by the initialBodyParts. Both lists should be equal at the start of execution, and both have to be filled manually.
    /// </summary>
    public void ResetTexturesAndMeshes()
    {

        for (int i = 0; i < bodyParts.Count; i++)
        {
            List<Material> bodyPartInitialMaterials = initialBodyParts[i].bodyPartMaterial;
            levelData.textureModifierScript.CopyTextures(bodyParts[i].bodyPartMesh,bodyPartInitialMaterials);
        }

        for (int i = 0; i < initialBodyParts.Count; i++)
        {
            levelData.avatarUpdateScript.UpdateMesh(i,initialBodyParts[i].bodyPartMesh);
            
        }
    }

    
}
