using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Orchestrator : MonoBehaviour
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

        if(buttonData.buttonType.ToString()=="Mesh" && buttonData.associatedMesh!=null)
        {
            UpdateMesh(buttonData.bodyPartIndex,buttonData.associatedMesh);
        }
        else if(buttonData.buttonType.ToString()=="Texture_Color" && buttonData.associatedTexture!= null)
        {
            BodyPart bodyPart = levelData.bodyPartListScript.bodyParts[buttonData.bodyPartIndex];

            int indexOfMaterial = FindMaterialMatchInList(bodyPart.bodyPartMaterial,buttonData.associatedTexture);
            
            if(indexOfMaterial!=-1)
            {
                UpdateTextureColor(buttonData.associatedAttribute,bodyPart.bodyPartMesh,indexOfMaterial, buttonData.associatedColor);
            }

            indexOfMaterial = -1;
            
            for (int i = 0; i < bodyPart.textureLinkedBodyParts.Count; i++)
            {
                for (int j = 0; j<levelData.bodyPartListScript.bodyParts.Count; j++)
                {
                    if(bodyPart.textureLinkedBodyParts[i].name==levelData.bodyPartListScript.bodyParts[j].name)
                    {
                       indexOfMaterial = FindMaterialMatchInList(levelData.bodyPartListScript.bodyParts[j].bodyPartMaterial,buttonData.associatedTexture);

                       if(indexOfMaterial!=-1)
                       {
                           UpdateTextureColor(buttonData.associatedAttribute,levelData.bodyPartListScript.bodyParts[j].bodyPartMesh,indexOfMaterial, buttonData.associatedColor);
                       }  
                    }
                }
                
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
    public void UpdateMesh(int meshIndex,GameObject newMesh)
    {
        meshSwapScript.SwapMesh(meshIndex,newMesh);
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
    public void UpdateTextureColor(string _attributeName, GameObject texturedObject, int indexOfMaterial, Color newColor)
    {
        //If no attribute was specified, use the value of colorAttributeName as the fallback attribute
        if(string.IsNullOrEmpty(_attributeName) && !string.IsNullOrEmpty(colorAttributeName))
        {
            textureSwapScript.UpdateTexture(colorAttributeName,texturedObject,indexOfMaterial,newColor);
        }
        else
        {
            textureSwapScript.UpdateTexture(_attributeName,texturedObject,indexOfMaterial,newColor);
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
}
