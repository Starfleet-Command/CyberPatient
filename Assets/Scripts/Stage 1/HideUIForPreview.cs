using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HideUIForPreview : MonoBehaviour
{
    [SerializeField] private List<Canvas> uiElementsToHide;
    [SerializeField] private List<GameObject> uiElementsToUnhide;
    private bool isVisible=true;


    /// <summary>
    /// This function toggles between hiding the UI Elements specified in uiElementsToHide/unhiding the ones in uiElementsToUnhide and doing the opposite. 
    /// This function should be linked to the preview button.
    /// </summary>
    public void ToggleUI()
    {
        if(isVisible)
        {
            HideUI();
        }

        else
        {
            ShowUI();
        }

        isVisible = !isVisible;
    }

    /// <summary>
    /// This function hides the UI elements stored in uiElementsToHide, and specifically unhides those in uiElementsToUnhide, in case that we want to show specific UI elements in the canvases that have been hidden
    /// </summary>
    private void HideUI()
    {
        foreach (Canvas uiCanvas in uiElementsToHide)
        {
                uiCanvas.gameObject.SetActive(false);
        }

        foreach (GameObject uiElement in uiElementsToUnhide)
        {
            if(!uiElement.activeSelf)
                uiElement.SetActive(true);
        }
        
    }


    /// <summary>
    /// This function acts as the opposite for the HideUI function.
    /// </summary>
    private void ShowUI()
    {
        foreach (Canvas uiCanvas in uiElementsToHide)
        {
                uiCanvas.gameObject.SetActive(true);
        }
       
    }
}
