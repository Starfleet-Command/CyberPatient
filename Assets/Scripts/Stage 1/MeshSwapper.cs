using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSwapper : MonoBehaviour
{
    private StageOneStaticData levelData;
    private BodyPartRepository bodyPartList;

    private void Start()
    {
        levelData = StageOneStaticData.Instance;
        bodyPartList= levelData.bodyPartListScript;
        
    }
    public void SwapMesh(int meshIndex, GameObject newMesh)
    {
        GameObject currentMesh = bodyPartList.bodyParts[meshIndex].bodyPartMesh;

        if(!GameObject.ReferenceEquals(currentMesh, newMesh))
        {
            GameObject _meshInstance;
            _meshInstance = Instantiate(newMesh,currentMesh.transform.position, currentMesh.transform.rotation);
            _meshInstance.transform.localScale = levelData.avatarObject.transform.localScale;
            _meshInstance.transform.SetParent(bodyPartList.bodyParts[meshIndex].bodyPartParent.transform);
            StageOneEventManager.SelectedMeshChanged(_meshInstance);
            
        }
        
    }
}
