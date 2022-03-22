using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPhaseTwoInfo : MonoBehaviour
{
    public float bmi;
    public Dictionary<string, float> phaseInfo = new Dictionary<string, float>();
    public Dictionary<string, string> characterSelectInfo= new Dictionary<string, string>();
    [SerializeField] private float startingHeight;
    [SerializeField] private float startingWeight;

    private void Start()
    {
        bmi = ((startingWeight/startingHeight)/startingHeight)*10000; //Assuming that weight is in kg and height is in cm.  

        phaseInfo.Add("Weight",startingWeight);
        phaseInfo.Add("Height",startingHeight);
        phaseInfo.Add("BMI",bmi);

        InitModelDictionary();
    }

    public void InitModelDictionary()
    {
        foreach (string name in BodyPartEnum.GetNames(typeof(BodyPartEnum)))
        {
            characterSelectInfo.Add(name,"none");
            characterSelectInfo.Add(name+"_Color","none");
        }

    }

    public void ModifyCharacterInfo(string key, string value)
    {
        if(characterSelectInfo.ContainsKey(key))
            characterSelectInfo[key] = value;
    }

    public void PrintCharacterInfo()
    {
        foreach (KeyValuePair<string, string> category in characterSelectInfo)
        {
            Debug.Log(""+category.Key + ": "+category.Value);
        }

    }

    public string PrepDataForExport()
    {
        string returnString="";

        foreach (KeyValuePair<string, string> category in characterSelectInfo)
        {
            returnString += ""+category.Key+": "+category.Value+"\n\n";
        }

        foreach (KeyValuePair<string, float> category in phaseInfo)
        {
            returnString += ""+category.Key+": "+category.Value.ToString()+"\n\n";
        }

        return returnString;
    }

}
    //Fill with the remaining info you want to pass to phase two. 
