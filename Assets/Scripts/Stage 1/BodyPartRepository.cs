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

    public void UpdateBodyMeshReference(GameObject _mesh)
    {
        foreach (BodyPart part in bodyParts)
        {
            if(_mesh.transform.parent.gameObject == part.bodyPartParent)
            {
                Destroy(part.bodyPartMesh);
                part.bodyPartMesh = _mesh;
            }   
        }
        
    }

    public void UpdateTextureReference<T>(string attributeName, Material _material, T newValue)
    {

    }

    public void ResetTexturesAndMeshes()
    {
        for (int i = 0; i < initialBodyParts.Count; i++)
        {
            levelData.avatarUpdateScript.UpdateMesh(i,initialBodyParts[i].bodyPartMesh);
        }
    }
}
