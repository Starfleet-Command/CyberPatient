using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
  public int bodyPartIndex;

  public string associatedAttribute;
  public Color associatedColor;
  public GameObject associatedMesh;
  public Material associatedTexture;
  public float newValue;
  
}
