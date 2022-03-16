using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExtractEditableBones : MonoBehaviour
{
    [SerializeField] private string editableBonePrefix="adj";
    [SerializeField] private GameObject objectToExtractFrom;

    #if UNITY_EDITOR
    [ReadOnly] public List<GameObject> editableBoneObjects;

    #endif

    #if !UNITY_EDITOR
    public List<GameObject> editableBoneObjects;

    #endif
    
    public List<EditableBone> bonesInModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Extract Bones")]
    public void extractBones()
    {
        editableBoneObjects.Clear();
        foreach (Transform child in objectToExtractFrom.GetComponentsInChildren<Transform>())
        {
            if(child.gameObject.name.Contains(editableBonePrefix))
            {
                editableBoneObjects.Add(child.gameObject);

                if(bonesInModel.Count < editableBoneObjects.Count)
                {
                    bonesInModel.Add(new EditableBone(child.gameObject));
                }
                
            }

            
        }
    }

    [ContextMenu("Clear Lists")]
    public void ClearLists()
    {
        editableBoneObjects.Clear();
        bonesInModel.Clear();
    }

    [System.Serializable]
    public struct EditableBone
    {
        public EditableBoneOptions boneName;
        public GameObject boneObject;

        public EditableBone(GameObject _boneObject)
        {
            boneName = (EditableBoneOptions)(EditableBoneOptions.GetValues(typeof(EditableBoneOptions))).GetValue(0);
            boneObject = _boneObject;
        }
    }

    public GameObject GetObjectOfBone(EditableBoneOptions boneName)
    {
        foreach (EditableBone _bone in bonesInModel)
        {
            if(_bone.boneName == boneName)
            {
                return _bone.boneObject;
            }
        }
        
        return null;
    }
    
}



#if UNITY_EDITOR

public class ReadOnlyAttribute : PropertyAttribute
{

}

[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property,
                                            GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }

    public override void OnGUI(Rect position,
                            SerializedProperty property,
                            GUIContent label)
    {
        GUI.enabled = false;
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;
    }
}

#endif
