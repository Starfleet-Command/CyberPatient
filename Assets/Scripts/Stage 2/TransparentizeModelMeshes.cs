using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentizeModelMeshes : MonoBehaviour
{
    private BodyPartModelReference modelBodyPartScript;
    // Start is called before the first frame update
    void Start()
    {
        modelBodyPartScript = GameObject.FindWithTag("Player").transform.GetChild(0).GetComponent<BodyPartModelReference>();
    }

    public void HideAllButOnePart(BodyPartEnum visiblePartName)
    {
        foreach (BodyPart part in modelBodyPartScript.initialModelParts)
        {
            if(part.name!=visiblePartName)
            {
                part.bodyPartParent.SetActive(false);
            }
        }
    }

    public void HideSinglePart(BodyPartEnum _partToHide)
    {
        BodyPart partToHide = BodyPart.GetPartByName(_partToHide,modelBodyPartScript.initialModelParts);

        if(partToHide != null)
            partToHide.bodyPartParent.SetActive(false);
        
    }

    public void ShowAll()
    {
        foreach (BodyPart part in modelBodyPartScript.initialModelParts)
        {
            if(!part.bodyPartParent.activeSelf)
            {
                part.bodyPartParent.SetActive(true);
            }
        }
    }

    public void ShowSinglePart(BodyPartEnum _partToShow)
    {
        BodyPart partToShow = BodyPart.GetPartByName(_partToShow,modelBodyPartScript.initialModelParts);

        if(partToShow != null)
            partToShow.bodyPartParent.SetActive(true);
    }

    
}
