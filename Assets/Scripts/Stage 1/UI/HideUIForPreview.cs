using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HideUIForPreview : MonoBehaviour
{
    [SerializeField] private List<Canvas> uiCanvasToHide;
    [SerializeField] private List<GameObject> uiElementsToHide;
    private bool isVisible=true;


    /// <summary>
    /// This function toggles between hiding the UI Elements specified in uiCanvasToHide/unhiding the ones in uiElementsToUnhide and doing the opposite. 
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
    /// This function hides the UI elements stored in uiCanvasToHide, and specifically unhides those in uiElementsToUnhide, in case that we want to show specific UI elements in the canvases that have been hidden
    /// </summary>
    private void HideUI()
    {
        foreach (Canvas uiCanvas in uiCanvasToHide)
        {
            if(uiCanvas.gameObject.activeSelf && uiCanvas != null)
                uiCanvas.gameObject.SetActive(false);
        }

        foreach (GameObject uiElement in uiElementsToHide)
        {
            if(uiElement.activeSelf)
                uiElement.SetActive(false);
        }
        
    }


    /// <summary>
    /// This function acts as the opposite for the HideUI function.
    /// </summary>
    private void ShowUI()
    {
        foreach (Canvas uiCanvas in uiCanvasToHide)
        {
            if(!uiCanvas.gameObject.activeSelf && uiCanvas != null)
                uiCanvas.gameObject.SetActive(true);
        }

        foreach (GameObject uiElement in uiElementsToHide)
        {
            if(!uiElement.activeSelf)
                uiElement.SetActive(true);
        }
       
    }
}
