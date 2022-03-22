using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiToggleScript : MonoBehaviour
{
    public BodyPartEnum part;
    public ToggleActionEnum action;

    private StageTwoStaticData levelData;

    void Start()
    {
        levelData = StageTwoStaticData.Instance;
    }

    public void ActionOnToggleFlip(bool toggleStatus)
    {
        if(toggleStatus==true)
        {
            if(action==ToggleActionEnum.HideAllButOnePart)
            {
                levelData.transparentToggleScript.ShowAll();
            }

            else if(action==ToggleActionEnum.HideOnePart)
            {
                levelData.transparentToggleScript.ShowSinglePart(part);
            }

        }

        else
        {
            if(action==ToggleActionEnum.HideAllButOnePart)
            {
                levelData.transparentToggleScript.HideAllButOnePart(part);
            }

            else if(action==ToggleActionEnum.HideOnePart)
            {
                levelData.transparentToggleScript.HideSinglePart(part);
            }
        }
    }

    public enum ToggleActionEnum
    {
        HideAllButOnePart,
        HideOnePart,
    }
}
