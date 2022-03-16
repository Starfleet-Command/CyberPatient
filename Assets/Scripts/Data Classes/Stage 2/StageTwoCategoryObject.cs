using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Category", menuName = "ScriptableObjects/StageTwoCategoryObject", order = 1)]
[System.Serializable]
public class StageTwoCategoryObject : ScriptableObject
{
    public string title;
    public Section[] subcategories;

}

[System.Serializable]
public class Section
{
    public string title;
    public Property[] properties;
}

[System.Serializable]
public class Property
{
    public string name;
    public string bodyPartName;
    public SubProperty[] subproperties;
}

[System.Serializable]
public class SubProperty
{
    public string title;
    public PropertyTypes type;
    public Option[] options;
}

[System.Serializable]
public class Option
{
    public string title;
    public Deformation[] deformations;
    public string shaderAttribute="None";
    public HotspotTypes hotspotName;
    public AudioClip clip=null;

    public static Option FindByTitle(string title, List<Option> options)
    {
        foreach (Option _option in options)
        {
            if(_option.title == title)
            {
                return _option;
            }
        }

        return null;
    }
}

[System.Serializable]
public class Deformation
{
    public EditableBoneOptions objectToDeform;
    public Vector3 deformation;
}

