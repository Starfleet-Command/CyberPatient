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

    /// <summary>
    /// This function swaps the mesh at the body part specified by meshIndex from the current one to the one provided by newMesh, and carries over the textures.  
    /// </summary>
    /// <param name="meshIndex">
    /// The index of the body part that will have its mesh swapped.
    /// </param>
    /// <param name="newMesh">
    /// The new mesh that will be swapped in.
    /// </param>
    public void SwapMesh(int meshIndex, GameObject newMesh)
    {
        GameObject currentMesh = bodyPartList.bodyParts[meshIndex].bodyPartMesh;
        List<Material> meshMaterials = MaterialUtilities.getAllMaterialsFromObject(currentMesh);

        if(!GameObject.ReferenceEquals(currentMesh, newMesh))
        {
            GameObject _meshInstance;
            List<Material> newMeshMaterials = new List<Material>();

            _meshInstance = Instantiate(newMesh,currentMesh.transform.position, currentMesh.transform.rotation);
            _meshInstance.transform.localScale = levelData.avatarObject.transform.localScale;
            _meshInstance.transform.SetParent(bodyPartList.bodyParts[meshIndex].bodyPartParent.transform);

            //Important to trigger the event before the materials change because otherwise sharedMaterials become a copy of instanced materials.
            StageOneEventManager.SelectedMeshChanged(_meshInstance);

            levelData.textureModifierScript.CopyTextures(_meshInstance,meshMaterials);
            
        }
        
    }

    public void SwapMesh(BodyPartEnum _part, int _partIndex )
    {
        BodyPart partToChange;
        int currentIndex = 0;
        partToChange = BodyPart.GetPartByName(_part, bodyPartList.bodyParts);


        Component[] arrayOfChildren = partToChange.bodyPartParent.GetComponentsInChildren<Transform>(true);

        List<Component> listOfChildren = new List<Component>(arrayOfChildren);
        listOfChildren.Remove(partToChange.bodyPartParent.transform);

        if(_partIndex < listOfChildren.Count)
        {
            foreach (Transform child in listOfChildren)
            {
                if(currentIndex == _partIndex)
                {
                    List<Material> meshMaterials = new List<Material>(MaterialUtilities.getAllMaterialsFromObject(partToChange.bodyPartMesh));
                    
                    child.gameObject.SetActive(true);
                    StageOneEventManager.SelectedMeshChanged(child.gameObject);


                    listOfChildren.Remove(child);
                    foreach (Transform restChild in listOfChildren)
                    {
                        
                        restChild.gameObject.SetActive(false);
                    }
                    
                    levelData.textureModifierScript.CopyTextures(child.gameObject,meshMaterials);
                    break;
                }

                currentIndex++;
            }
        }
        
    }
}
