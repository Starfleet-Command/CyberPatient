using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderInstantiator : MonoBehaviour
{
    private StageOneStaticData levelData;
    private List<Slider> listOfSliders = new List<Slider>();
    private List<float> sliderDefaultValues = new List<float>();
    private List<SliderCategory> sliderInfo = new List<SliderCategory>();

    [SerializeField] private float slope = 0.02f;
    [SerializeField] private float b=-1.2f;
    [SerializeField] private GameObject sliderPrefab;
    [SerializeField] private GameObject UiSliderParent;

    private void Start()
    {
        levelData = StageOneStaticData.Instance;

    }

    /// <summary>
    /// This function creates a new instance of a slider (used currently for height and weight) and adds it to the UI
    /// </summary>
    /// <param name="category">
    /// The category from which the slider gets its maximum, minimum and default values.
    /// </param>
    /// <param name="isSpecialSlider">
    /// A flag that indicates whether the slider is a special slider, which behaves differently in that it does not affect blend shapes like the other sliders.
    /// </param>
    public void InstantiateSlider(SliderCategory category, bool isSpecialSlider)
    {
        GameObject sliderObjectInstance;
        Slider _sliderInstance;
        sliderObjectInstance = Instantiate(sliderPrefab);
        _sliderInstance = sliderObjectInstance.GetComponent<Slider>();

        listOfSliders.Add(_sliderInstance);

        sliderObjectInstance.transform.SetParent(UiSliderParent.transform);
        _sliderInstance.maxValue = category.maxValue;
        _sliderInstance.minValue = category.minValue;
        _sliderInstance.value = category.defaultValue;

        sliderDefaultValues.Add(category.defaultValue);
        sliderInfo.Add(category);
        
        if(!isSpecialSlider)
        {
            _sliderInstance.onValueChanged.AddListener(delegate {ChangedSliderValue(_sliderInstance);});
            InitSingleSliderValue(listOfSliders.Count-levelData.specialSliderCount);
        }

        else
        {
            _sliderInstance.onValueChanged.AddListener(delegate {ChangedHeightSliderValue(_sliderInstance);});
            ChangedHeightSliderValue(_sliderInstance);
        }

                
    }

    /// <summary>
    /// This function sets the value of all the sliders to their default value.
    /// </summary>
    public void InitSliderValues()
    {

     for (int i = 0; i < listOfSliders.Count; i++)
     {
         listOfSliders[i].value = sliderDefaultValues[i];

         if(sliderInfo[i].isSpecialSlider)
         {
            ChangedHeightSliderValue(listOfSliders[i]);
         }
         else
         {
            levelData.dataControllerScript.BlendShapeChangeOnSlider(i,sliderDefaultValues[i]);
            
         }
         
     }


        
    }
    
    /// <summary>
    /// This function resets the value of a slider with the specified index back to its original value
    /// </summary>
    /// <param name="index">
    /// The index of the slider in the list of sliders.
    /// </param>
    public void InitSingleSliderValue(int index)
    {

         levelData.dataControllerScript.BlendShapeChangeOnSlider(index,sliderDefaultValues[index]);
         listOfSliders[index].value = sliderDefaultValues[index];
        
    }

    /// <summary>
    /// This function is the subscriber to the OnChange event for the normal sliders. It uses the new value to call for the blend shape modification.
    /// </summary>
    /// <param name="slider">
    /// The reference to the slider that triggered the OnChange event
    /// </param>
    public void ChangedSliderValue(Slider slider)
    {   
        int _sliderIndex;
        _sliderIndex= slider.transform.GetSiblingIndex();
        levelData.dataControllerScript.BlendShapeChangeOnSlider(_sliderIndex, slider.value);
    }

    /// <summary>
    /// This function is the subscriber to the OnChange event for the special sliders. It uses the new value to resize the model.
    /// </summary>
    /// <param name="slider">
    /// The reference to the slider that triggered the OnChange event
    /// </param>
    public void ChangedHeightSliderValue(Slider slider)
    {
        float newValue = ConvertHeightToScale(slider.value);
        levelData.dataControllerScript.ChangeModelHeight(newValue);

    }

    /// <summary>
    //This calculation translates the value from the height scale of 130cm-210cm to the actual scale value the object will use (1.6-3)
    /// </summary>
    /// <param name="heightValue">
    /// The new value of the slider, that corresponds to the height of the avatar.
    /// </param>
    /// <returns >
    /// The height converted to an appropriate value for Unity to use as its scale. 
    /// </returns>
    private float ConvertHeightToScale(float heightValue)
    {
        float newNormalizedValue = 0f;
        newNormalizedValue = (slope*heightValue)+b;

        return newNormalizedValue;
    }
}
