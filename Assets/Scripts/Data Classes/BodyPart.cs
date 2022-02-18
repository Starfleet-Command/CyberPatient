using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyPart
{
    public string name;
    public GameObject bodyPartParent;
    public Material[] bodyPartMaterial;
    public GameObject bodyPartMesh;

    public BodyPart(string partName, GameObject parent, Material[] materials, GameObject mesh)
    {
        name = partName;
        bodyPartMaterial = materials;
        bodyPartMesh = mesh;
        bodyPartParent = parent;
    }

    public BodyPart(BodyPart part)
    {
        name = part.name;
        bodyPartMaterial = part.bodyPartMaterial;
        bodyPartMesh = part.bodyPartMesh;
        bodyPartParent = part.bodyPartParent;
    }
}
