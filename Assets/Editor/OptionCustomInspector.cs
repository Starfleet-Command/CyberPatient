 using UnityEngine;
 using System.Collections;
 using UnityEditor;
 using System;
 
 [CustomEditor(typeof(StageOneOptionObject))]
 public class OptionCustomInspector : Editor
 {

    SerializedProperty thumbnailProp;
    SerializedProperty bodyPartIndexProp;
    SerializedProperty buttonTypeProp;
    SerializedProperty associatedAttributeProp;
    SerializedProperty associatedTextureProp;
    SerializedProperty associatedColorProp;
    SerializedProperty meshOptionIndexProp;
    SerializedProperty newValueProp;

    void OnEnable()
    {
        // Fetch the objects from the GameObject script to display in the inspector
        thumbnailProp = serializedObject.FindProperty("thumbnail");
        bodyPartIndexProp = serializedObject.FindProperty("bodyPartIndex");
        buttonTypeProp = serializedObject.FindProperty("buttonType");
        associatedAttributeProp  = serializedObject.FindProperty("associatedAttribute");
        associatedTextureProp  = serializedObject.FindProperty("associatedTexture");
        associatedColorProp  = serializedObject.FindProperty("associatedColor");
        meshOptionIndexProp  = serializedObject.FindProperty("meshOptionIndex");
        newValueProp  = serializedObject.FindProperty("newValue");
    }
 
    public override void OnInspectorGUI()
    {
        StageOneOptionObject script = (StageOneOptionObject)target;

        //Property Fields automatically handle the type representation in the inspector. 

        EditorGUILayout.PropertyField(thumbnailProp, new GUIContent("Thumbnail"));
        EditorGUILayout.PropertyField(bodyPartIndexProp, new GUIContent("Body Part Index"));
        EditorGUILayout.PropertyField( buttonTypeProp,new GUIContent("Button Type") );
        serializedObject.ApplyModifiedProperties();


        //The cascading conditionals are a little hardcoded but when working with enums it is complicated to make them both readable and expandable.
        //Any changes to the enum require additional coding here to generate dynamic behaviour in the inspector.

        if (script.buttonType == StageOneOptionObject.Types.Texture_Color)
        {
            EditorGUILayout.PropertyField(associatedAttributeProp, new GUIContent("Attribute Name"));
            EditorGUILayout.PropertyField(associatedColorProp, new GUIContent("Color"));
            
        }

        else if(script.buttonType == StageOneOptionObject.Types.Texture_New)
        {
            EditorGUILayout.PropertyField(associatedTextureProp, new GUIContent("Material"));
        }
        else if(script.buttonType == StageOneOptionObject.Types.Mesh)
        {
            EditorGUILayout.PropertyField(meshOptionIndexProp, new GUIContent("Mesh Option"));
        }

        else if(script.buttonType == StageOneOptionObject.Types.Texture_Attribute)
        {
            EditorGUILayout.PropertyField(associatedAttributeProp, new GUIContent("Attribute Name"));
            EditorGUILayout.PropertyField(newValueProp, new GUIContent("Attribute Value"));
        }

        serializedObject.ApplyModifiedProperties();

    }
 }