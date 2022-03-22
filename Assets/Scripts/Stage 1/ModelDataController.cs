using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelDataController : MonoBehaviour
{
    private int blendShapeCount;
    private StageOneStaticData levelData;

    void Start()
    {
        levelData = StageOneStaticData.Instance;
        
        blendShapeCount = levelData.blendShapeScript.getBlendShapeCount();
        
        PopulateUI(levelData.allCategories);
       
    }

    /// <summary>
    /// This function dynamically generates the UI elements for the primary menu, both the sliders and the category icon buttons. 
    /// </summary>
    /// <param name="slidersToGenerate">
    /// The array of slider categories that will be turned into a UI slider
    /// </param>
    /// <param name="iconsToGenerate">
    /// The array of icon categories that will be turned into a UI icon button-
    /// </param>
    private void PopulateUI(CategoryDefinitionObject primaryButtonData)
    {

        GeneratePrimaryButtons(primaryButtonData,levelData.primaryButtonsPerPage,1);
        
    }


    public void GeneratePrimaryButtons(CategoryDefinitionObject primaryButtonData, int amountToGenerate, int pageIndex)
    {
        ImageCategory[] iconsToGenerate = primaryButtonData.buttonCategories;
        SliderCategory[] slidersToGenerate = primaryButtonData.sliderCategories;

        levelData.imageInstantiatorScript.ResetButtonMenu();
        levelData.imageInstantiatorScript.UnloadSecondaryMenu();

        //If the buttons to generate are image categories only
        if(iconsToGenerate.Length >= (amountToGenerate*pageIndex))
        {
            for (int j = amountToGenerate*(pageIndex-1); j < amountToGenerate*pageIndex; j++)
            {
                levelData.imageInstantiatorScript.InstantiateButtonMenuItem(iconsToGenerate[j]);
            }
        }
        //If there is a mix between image and slider categories
        else if((iconsToGenerate.Length+slidersToGenerate.Length)>= (amountToGenerate*pageIndex))
        {
            for (int j = amountToGenerate*(pageIndex-1); j<iconsToGenerate.Length; j++)
            {
                levelData.imageInstantiatorScript.InstantiateButtonMenuItem(iconsToGenerate[j]);
            }

            for (int i = 0; i< (amountToGenerate*pageIndex)-iconsToGenerate.Length; i++)
            {
                levelData.imageInstantiatorScript.InstantiateButtonMenuItem(slidersToGenerate[i]);
            }
        }
        //If the buttons are slider categories only.
        else
        {
            for (int i = (amountToGenerate*(pageIndex-1))-iconsToGenerate.Length; i<slidersToGenerate.Length;i++)
            {
                levelData.imageInstantiatorScript.InstantiateButtonMenuItem(slidersToGenerate[i]);
            }
        }

    }


    public void GenerateSlider(SliderCategory sliderToGenerate, bool isSpecialSlider)
    {
        if(isSpecialSlider)
        {
            levelData.sliderInstantiatorScript.InstantiateSlider(sliderToGenerate,true);
        }

        else
        {
            levelData.sliderInstantiatorScript.InstantiateSlider(sliderToGenerate,false);
        }
    }


    /// <summary>
    /// This function is a wrapper for the ChangeBlendShape function found in the BlendShapeHandler script. In order to reduce reference spaghetti, all calls for that function should be made through this wrapper. 
    /// </summary>
    /// <param name="blendShapeIndex">
    /// The index of the blend shape to be changed. Unity does not support blend shape influences 
    /// </param>
    /// <param name="newValue">
    /// The new value the blend shape will take. While supported, going above 100 and below 0 can cause graphical glitches.
    /// </param>
    public void BlendShapeChangeOnSlider(int blendShapeIndex,float newValue)
    {
        levelData.blendShapeScript.ChangeBlendShape(blendShapeIndex, newValue);
    }


    public void ResetAllValues()
    {
        levelData.sliderInstantiatorScript.InitSliderValues();
        levelData.bodyPartListScript.ResetTexturesAndMeshes();
    }


}
