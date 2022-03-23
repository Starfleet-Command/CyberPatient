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
    /// 
    /// </summary>
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
                    
                    TextureModifier.CopyTextures(child.gameObject,meshMaterials);
                    break;
                }

                currentIndex++;
            }
        }
        
    }
}
