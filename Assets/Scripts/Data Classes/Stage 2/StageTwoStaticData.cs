using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTwoStaticData : MonoBehaviour
{
    public static StageTwoStaticData Instance;
    private void Awake() => Instance = this;


    public InvisibleSkinMeshData skinDataScript;
    public StageTwoAvatarFunctions avatarFunctionsScript;
    public ChangeOnOptionSelect avatarEffectsOnOptionSelectScript;
    public VitalSignsConfigurationObject vitalSignData;
    public StageTwoCategoryObject[] listOfCategories;
    
}

public enum HotspotTypes
{
    None,
    LeftLung,
    RightLung,
    Aortic,
    Mitral,
    Liver,
    Bowel,
}

public enum PropertyTypes
{
    Texture,
    Deformation,
    Audio,
    AnimatedTexture,
}
