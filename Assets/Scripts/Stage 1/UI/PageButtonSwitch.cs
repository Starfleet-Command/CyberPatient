using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageButtonSwitch : MonoBehaviour
{
    private StageOneStaticData levelData;
    
    
    void Start()
    {
       levelData = StageOneStaticData.Instance; 
    }

    public void SwitchPrimaryButtonPage(Button button)
    {
        int pageIndex = button.gameObject.transform.GetSiblingIndex()+1;
        levelData.dataControllerScript.GeneratePrimaryButtons(levelData.allCategories,levelData.primaryButtonsPerPage,pageIndex);
    }
}
