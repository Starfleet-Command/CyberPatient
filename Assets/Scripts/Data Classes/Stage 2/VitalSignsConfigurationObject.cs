using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/VitalSignsConfigurationObject", order = 1)]
[System.Serializable]
public class VitalSignsConfigurationObject : ScriptableObject
{
    public List<VitalSignCategory> Categories;
    public List<VitalSignCategory> nonEditableCategories;

}

[System.Serializable]
public class VitalSignCategory
{
    public string categoryName;
    public string unitOfMeasurement;
    public float defaultValue = 0.0f;
    public VitalSignClassBounds[] bounds;
    

}

[System.Serializable]
public class VitalSignClassBounds
{
    public string rangeName;
    public float lowerBound;
    public float upperBound;
    
}

