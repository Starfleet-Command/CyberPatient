using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyPart
{
    public BodyPartEnum name;
    public GameObject bodyPartParent;
    public List<Material> bodyPartMaterial;
    public GameObject bodyPartMesh;
    public List<BodyPartEnum> textureLinkedBodyParts;
    public List<GameObject> additionalPartMeshes;

    public BodyPart(BodyPartEnum _name, GameObject _bodyPartParent, List<Material> _bodyPartMaterial, GameObject _bodyPartMesh)
    {
        name = _name;
        bodyPartParent = _bodyPartParent;
        bodyPartMaterial  = _bodyPartMaterial;
        bodyPartMesh = _bodyPartMesh;
        textureLinkedBodyParts = new List<BodyPartEnum>();
        additionalPartMeshes = new List<GameObject>();
    }

    public BodyPart(BodyPartEnum _name, GameObject _bodyPartParent, List<Material> _bodyPartMaterial, GameObject _bodyPartMesh, List<GameObject> _additionalMeshes)
    {
        name = _name;
        bodyPartParent = _bodyPartParent;
        bodyPartMaterial  = _bodyPartMaterial;
        bodyPartMesh = _bodyPartMesh;
        additionalPartMeshes = _additionalMeshes;
        textureLinkedBodyParts = new List<BodyPartEnum>();
        
    }

    public BodyPart(BodyPart existingPart)
    {
        name = existingPart.name;
        bodyPartParent = existingPart.bodyPartParent;
        bodyPartMaterial  = existingPart.bodyPartMaterial;
        bodyPartMesh = existingPart.bodyPartMesh;
        textureLinkedBodyParts = existingPart.textureLinkedBodyParts;
        additionalPartMeshes = existingPart.additionalPartMeshes;
    }

    public static BodyPart GetPartByName(BodyPartEnum name, List<BodyPart> partList)
    {
        foreach (BodyPart part in partList)
        {
            if(part.name == name)
            {
                return part;
            }   
        }

        return null;
    }

    public static BodyPart GetPartByMesh(GameObject mesh, List<BodyPart> partList)
    {
        foreach (BodyPart part in partList)
        {

            if(part.bodyPartMesh.name == mesh.name)
            {
                
                return part;
            }

            foreach (GameObject extraMesh in part.additionalPartMeshes)
            {
                if(extraMesh.name == mesh.name)
                {
                    return part;
                }
            }   
        }

        return null;
    }
    
}


//New single mesh body parts should be added here
public enum BodyPartEnum
{
    Hair,
    Head,
    Clothes,
    Body,
    Hotspots,
    Eyebrows,
    Eyes,
    Mouth,
}

