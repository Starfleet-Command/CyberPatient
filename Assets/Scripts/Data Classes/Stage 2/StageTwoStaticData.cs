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
    public TransparentizeModelMeshes transparentToggleScript;
    public StageTwoCategoryObject[] listOfCategories;
}

public enum HotspotTypes
{
    None,
    LeftUpperLung,
    RightUpperLung,
    LeftLowerLung,
    RightLowerLung,
    RightMiddleLung,
    Aortic,
    Tricuspid,
    Pulmonic,
    ErbPoint,
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

public enum EditableBoneOptions
{
RightLowerArm_A,
RightLowerArm_B,
RightUpperArm_A,
RightUpperArm_B,
LeftLowerArm_A,
LeftLowerArm_B,
LeftUpperArm_A,
LeftUpperArm_B,
FrontRightBreast,
FrontLeftBreast,
BackRightBreast,
BackLeftBreast,
RightTorso,
LeftTorso,
RightBack,
LeftBack,
RightGlute,
LeftGlute,
LowerLeftLeg_A,
LowerLeftLeg_B,
UpperLeftLeg_A,
UpperLeftLeg_B,
LowerRightLeg_A,
LowerRightLeg_B,
UpperRightLeg_A,
UpperRightLeg_B,
}
