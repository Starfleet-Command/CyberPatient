using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOnOptionSelect : MonoBehaviour
{
    private StageTwoStaticData levelData;

    private void Start()
    {
        levelData = StageTwoStaticData.Instance;
    }

    public void WhenDropdownOptionSelected(Option selectedOption,PropertyTypes dropdownType)
    {
        switch (dropdownType)
        {
            case PropertyTypes.Texture:
            //Modify a texture in a specific game object. TODO:see what goes into modifying a texture and add it to the option (mask enum, separate modif. class array, separate attribute names)
            break;

            case PropertyTypes.Deformation:

                GameObject avatarObject = GameObject.FindWithTag("Player");
                GameObject objectToDeform;
                ExtractEditableBones editableBoneScript = avatarObject.transform.GetChild(0).GetComponent<ExtractEditableBones>();

                foreach (Deformation _deformation in selectedOption.deformations)
                {
                    EditableBoneOptions boneToEdit = _deformation.objectToDeform;

                    objectToDeform = editableBoneScript.GetObjectOfBone(boneToEdit);

                    
                    //levelData.avatarFunctionsScript.ResetDeformations(objectToDeform);
                    levelData.avatarFunctionsScript.DeformMesh(objectToDeform, _deformation.deformation);
                }
                // Deform a series of bones

            break;

            case PropertyTypes.Audio:
            
                
                if(levelData.skinDataScript.typesHotspotDict.ContainsKey(selectedOption.hotspotName))
                {
                    levelData.skinDataScript.typesHotspotDict[selectedOption.hotspotName].soundClip = selectedOption.clip;
                }
                // Switch the audio file for a particular hotspot.
            break;

            case PropertyTypes.AnimatedTexture:
            // Modify an animated texture in a specific game object. This is not enabled in the vertical slice and is here as a expandability hook. 
            break;
            default:
            break;
        }
    }
}
