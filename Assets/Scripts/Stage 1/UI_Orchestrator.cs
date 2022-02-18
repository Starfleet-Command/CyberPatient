using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Orchestrator : MonoBehaviour
{
    [SerializeField] private MeshSwapper meshSwapScript;
    [SerializeField] private TextureModifier textureSwapScript;
    [SerializeField] private string colorAttributeName;

    private void OnEnable()
    {
        StageOneEventManager.OnOptionSelected+=UpdateAvatar;
    }

    private void OnDisable()
    {
        StageOneEventManager.OnOptionSelected-=UpdateAvatar;
    }
    
    public void UpdateAvatar(Button _button)
    {
        StageOneOptionObject buttonData = _button.GetComponent<SecondaryMenuDataHolder>().buttonData;

        if(buttonData.buttonType.ToString()=="Mesh" && buttonData.associatedMesh!=null)
        {
            UpdateMesh(buttonData.bodyPartIndex,buttonData.associatedMesh);
        }
        else if(buttonData.buttonType.ToString()=="Texture" && buttonData.associatedTexture!= null)
        {
            UpdateTextureColor(buttonData.associatedTexture);
        }
    }

    public void UpdateMesh(int meshIndex,GameObject newMesh)
    {
        meshSwapScript.SwapMesh(meshIndex,newMesh);
    }

    public void UpdateTextureColor(Material newTexture)
    {
        //textureSwapScript.UpdateTexture();
    }
}
