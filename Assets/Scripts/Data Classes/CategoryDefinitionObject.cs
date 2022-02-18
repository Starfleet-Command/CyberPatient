using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CategoryDefinitionObject", order = 1)]
public class CategoryDefinitionObject : ScriptableObject
{
  public ImageCategory[] buttonCategories;
  public SliderCategory[] sliderCategories;

}
