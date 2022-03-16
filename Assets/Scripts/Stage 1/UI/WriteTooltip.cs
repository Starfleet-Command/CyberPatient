using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WriteTooltip : MonoBehaviour
{
    [SerializeField] private Text tooltipTextField;
    [SerializeField] private ButtonCategoryHolder buttonInfo;

    public void SetTooltipText()
    {
        if(buttonInfo.buttonSliderCategory.categoryIcon == null)
            tooltipTextField.text = buttonInfo.buttonImageCategory.tooltip;

        else
            tooltipTextField.text = buttonInfo.buttonSliderCategory.tooltip;
    }
}
