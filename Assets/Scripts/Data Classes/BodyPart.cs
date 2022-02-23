using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyPart
{
    public string name;
    public GameObject bodyPartParent;
    public List<Material> bodyPartMaterial;
    public GameObject bodyPartMesh;
    public List<GameObject> textureLinkedBodyParts;
    
}
