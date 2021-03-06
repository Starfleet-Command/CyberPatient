using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AvatarUpdater : MonoBehaviour
{
    [SerializeField] private MeshSwapper meshSwapScript;
    [SerializeField] private TextureModifier textureSwapScript;
    [SerializeField] private string colorAttributeName;

    private StageOneStaticData levelData;

    private void OnEnable()
    {
        StageOneEventManager.OnOptionSelected+=UpdateAvatar;
    }

    private void OnDisable()
    {
        StageOneEventManager.OnOptionSelected-=UpdateAvatar;
    }

    private void Start()
    {
        levelData = StageOneStaticData.Instance;
    }


    /// <summary>
    /// This function triggers when a secondary menu button is pressed. Depending on the contents and type of the option, it either changes the mesh or changes a texture color.
    /// Any further options on functionality when button is pressed should be set here.
    /// </summary>
    /// <param name="_button">
    /// The reference to the button that has been pressed.
    /// </param>
    public void UpdateAvatar(Button _button)
    {
        StageOneOptionObject buttonData = _button.GetComponent<SecondaryMenuDataHolder>().buttonData;

        if(buttonData.buttonType.ToString()=="Mesh" && buttonData.meshOptionIndex>=0)
        {
            UpdateMesh(buttonData.bodyPartIndex,buttonData.meshOptionIndex);
        }
        else if(buttonData.buttonType.ToString()=="Texture_Color")
        {
            UpdateTextureWrapper(buttonData.bodyPartIndex,buttonData.associatedAttribute,buttonData.associatedColor,false);
        }
    }


    private void UpdateTextureWrapper(BodyPartEnum partName, string attributeName, Color newColor, bool isRecursiveCall)
    {
        BodyPart bodyPart = BodyPart.GetPartByName(partName,levelData.bodyPartListScript.bodyParts);

        levelData.avatarInfo.ModifyCharacterInfo(partName.ToString()+"_Color",newColor.ToString());
        UpdateTextureColor(attributeName,bodyPart.bodyPartMesh, newColor);

        // The calls the function again for all the identical materials that need to change when that body part changes. 
        if(!isRecursiveCall)
        {
            for (int i = 0; i < bodyPart.textureLinkedBodyParts.Count; i++)
            {
                UpdateTextureWrapper(bodyPart.textureLinkedBodyParts[i],attributeName,newColor,true);   
            }
        }

    }


    /// <summary>
    /// This function serves as a wrapper function to the MeshSwapper functionality. It is used so logical flow is simplified, and maintain consistency with interdependencies.
    /// </summary>
    /// <param name="meshIndex">
    /// The index of the body part in the bodyParts list that will be modified.
    /// </param>
    /// <param name="newMesh">
    /// The new mesh that will be swapped in.
    /// </param>
    public void UpdateMesh(BodyPartEnum _part, int _partIndex)
    {
        meshSwapScript.SwapMesh(_part,_partIndex);
    }

    /// <summary>
    /// This function serves as a wrapper function to the TextureModifier functionality. It is used so logical flow is simplified, and maintain consistency with interdependencies.
    /// </summary>
    /// <param name="_attributeName">
    /// the name of the shader attribute to change.
    /// </param>
    /// <param name="texturedObject">
    /// The object that will have its material changed. 
    /// </param>
    /// <param name="indexOfMaterial">
    /// The index of the material to be changed, in the array of materials held in the object. This argument is automatically found when called from UI_Orchestrator.
    /// </param>
    /// <param name="newColor">
    /// The new color that the attribute will change to.
    /// </param>
    public void UpdateTextureColor(string _attributeName, GameObject texturedObject, Color newColor)
    {
        //If no attribute was specified, use the value of colorAttributeName as the fallback attribute
        if(string.IsNullOrEmpty(_attributeName) && !string.IsNullOrEmpty(colorAttributeName))
        {
            textureSwapScript.UpdateTexture(colorAttributeName,texturedObject,newColor);
        }
        else
        {
            textureSwapScript.UpdateTexture(_attributeName,texturedObject,newColor);
        }
    }

    /// <summary>
    /// This helper function finds if a material is present in a list, and returns the index where it is located. If it is not located, it returns -1.
    /// </summary>
    /// <param name="materials">
    /// The list of materials that will be iterated on.
    /// </param>
    /// <param name="_materialToSearchFor">
    /// The material whose index is being searched for.
    /// </param>
    private int FindMaterialMatchInList(List<Material> materials, Material _materialToSearchFor)
    {
        int indexInList=-1;

        for (int i = 0; i < materials.Count; i++)
            {
                if(materials[i]==_materialToSearchFor)
                {
                    indexInList = i;
                }
            }

        return indexInList;
    }

    /// <summary>
    /// This function changes the height of the entire avatar, and it is called when the height slider is changed. 
    /// </summary>
    /// <param name="newHeight">
    /// The value that the height will be changed to. This value is provided by the ConvertHeightToScale() translation in SliderInstantiator
    /// </param>
    public void ChangeModelHeight(float percentageChange)
    {
        Vector3 fractionalScaleModifier = new Vector3(0,0,0);

        foreach (HeightBone bone in levelData.bodyPartListScript.heightModificationBones)
        {
            fractionalScaleModifier = bone.scaleModifier * percentageChange;
           
            bone.boneObject.transform.localScale = bone.originalScale + fractionalScaleModifier;
            
        }
    }
}
