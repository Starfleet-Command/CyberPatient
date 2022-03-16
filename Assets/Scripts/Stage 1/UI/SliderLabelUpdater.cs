using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderLabelUpdater : MonoBehaviour
{
    [SerializeField] private Slider _sliderToFollow;
    [SerializeField] private Text labelText;
    private StageOneStaticData levelData;
    public float slope;
    public float intercept;

    public int heightOrWeightSlider; //1 is height slider. -1 is weight slider

    private void Start()
    {
        _sliderToFollow.onValueChanged.AddListener (delegate {UpdateLabel(_sliderToFollow);});
        levelData = StageOneStaticData.Instance;
        UpdateLabel(_sliderToFollow);
    }

    public void UpdateLabel(Slider _slider)
	{
        float newLabelValue = Mathf.Floor(MathUtilities.LinearValueConversion(_slider.value,slope,intercept));
        labelText.text = newLabelValue.ToString();

        if(heightOrWeightSlider==-1)
        {
            levelData.avatarInfo.weight = newLabelValue;
        }

        else if(heightOrWeightSlider==1)
        {
            levelData.avatarInfo.height = newLabelValue;
        }
	}

}
