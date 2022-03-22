using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This scriptable object holds all the data required for the secondary menu buttons. 
//The custom editor script for this object is found at Editor/OptionCustomInspector

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/StageOneOptionObject", order = 1)]
[System.Serializable]
public class StageOneOptionObject : ScriptableObject
{
  public Texture2D thumbnail;

  public enum Types
  {
      Texture_Color,
      Texture_Attribute,
      Texture_New,
      Mesh,
  }

  public Types buttonType;
  //The body is not one 3D model, but various meshes as nested children. This is used to detect which mesh should be changed. 
  //The value of this variable should match that of the body part that you want to change with it. 
  public BodyPartEnum bodyPartIndex;

  public string associatedAttribute;
  public Color associatedColor;
  public int meshOptionIndex;
  public Material associatedTexture;
  public float newValue;
  
}

