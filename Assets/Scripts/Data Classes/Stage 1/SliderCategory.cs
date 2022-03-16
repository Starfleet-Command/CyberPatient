using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class SliderCategory
{
    public string categoryName;
    public Texture2D categoryIcon;
    public int minValue;
    public int maxValue;
    public float defaultValue=0.0f;
    public bool isSpecialSlider;
    public float equationSlope;
    public float equationIntercept;
    [TextArea(3,10)]
    public string tooltip;
}
