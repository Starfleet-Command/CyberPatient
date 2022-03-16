using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOneStaticData : MonoBehaviour
{
    //This class helps hold references to the most important scripts to avoid costly finds and reduce overhead if the scripts need to be switched

    public static StageOneStaticData Instance;
    private void Awake() => Instance = this;

    public  int specialSliderCount;
    public  int primaryButtonsPerPage;
    public  GameObject avatarObject;
    public  BlendShapeHandler blendShapeScript;
    public  ModelDataController dataControllerScript;
    public  SliderInstantiator sliderInstantiatorScript;
    public  ImageCategoryInstantiator imageInstantiatorScript;
    public  BodyPartRepository bodyPartListScript;
    public  AvatarUpdater avatarUpdateScript;
    public  MeshSwapper meshSwapperScript;
    public  TextureModifier textureModifierScript;
    public  CategoryDefinitionObject allCategories;
    public AvatarPhaseTwoInfo avatarInfo;
}
