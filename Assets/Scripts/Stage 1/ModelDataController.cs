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
        
        PopulateUI(levelData.allCategories.sliderCategories,levelData.allCategories.buttonCategories);
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
    private void PopulateUI(SliderCategory[] slidersToGenerate,ImageCategory[] iconsToGenerate)
    {
        if(blendShapeCount>=slidersToGenerate.Length-levelData.specialSliderCount)
        {
            for (int i = 0; i<slidersToGenerate.Length; i++)
            {
                if(slidersToGenerate[i].isSpecialSlider)
                {
                    levelData.sliderInstantiatorScript.InstantiateSlider(slidersToGenerate[i],true);
                }
                else
                    levelData.sliderInstantiatorScript.InstantiateSlider(slidersToGenerate[i],false);
            }

            
        }

        else
        {
            Debug.LogWarning("Attempting to generate more sliders than mesh has blend shapes.");

            for (int i = 0; i<blendShapeCount; i++)
            {
                levelData.sliderInstantiatorScript.InstantiateSlider(slidersToGenerate[i],false);
            }
            levelData.sliderInstantiatorScript.InstantiateSlider(slidersToGenerate[slidersToGenerate.Length-1],true);
        }

        for (int j = 0; j<iconsToGenerate.Length; j++)
        {
            levelData.imageInstantiatorScript.InstantiateButtonMenuItem(iconsToGenerate[j]);
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

    /// <summary>
    /// This function changes the height of the entire avatar, and it is called when the height slider is changed. 
    /// </summary>
    /// <param name="newHeight">
    /// The value that the height will be changed to. This value is provided by the ConvertHeightToScale() translation in SliderInstantiator
    /// </param>
    public void ChangeModelHeight(float newHeight)
    {
        levelData.avatarObject.transform.localScale = new Vector3(newHeight,newHeight,newHeight);
    }

    public void ResetAllValues()
    {
        levelData.sliderInstantiatorScript.InitSliderValues();
        levelData.bodyPartListScript.ResetTexturesAndMeshes();
    }

}
