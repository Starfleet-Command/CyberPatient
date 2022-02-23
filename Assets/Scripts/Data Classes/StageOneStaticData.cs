using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOneStaticData : MonoBehaviour
{

    public static StageOneStaticData Instance;
    private void Awake() => Instance = this;

    public  int specialSliderCount;
    public  GameObject avatarObject;
    public  BlendShapeHandler blendShapeScript;
    public  ModelDataController dataControllerScript;
    public  SliderInstantiator sliderInstantiatorScript;
    public  ImageCategoryInstantiator imageInstantiatorScript;
    public  BodyPartRepository bodyPartListScript;
    public  UI_Orchestrator avatarUpdateScript;
    public  MeshSwapper meshSwapperScript;
    public  TextureModifier textureModifierScript;
    public  CategoryDefinitionObject allCategories;
}
