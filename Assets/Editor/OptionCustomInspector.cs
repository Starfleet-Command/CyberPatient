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
    SerializedProperty associatedMeshProp;
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
        associatedMeshProp  = serializedObject.FindProperty("associatedMesh");
        newValueProp  = serializedObject.FindProperty("newValue");
    }
 
    public override void OnInspectorGUI()
    {
        StageOneOptionObject script = (StageOneOptionObject)target;


        EditorGUILayout.PropertyField(thumbnailProp, new GUIContent("Thumbnail"));
        EditorGUILayout.PropertyField(bodyPartIndexProp, new GUIContent("Body Part Index"));
        EditorGUILayout.PropertyField( buttonTypeProp,new GUIContent("Button Type") );
        serializedObject.ApplyModifiedProperties();

        if (script.buttonType == StageOneOptionObject.Types.Texture_Color)
        {
            EditorGUILayout.PropertyField(associatedAttributeProp, new GUIContent("Attribute Name"));
            EditorGUILayout.PropertyField(associatedTextureProp, new GUIContent("Texture Option"));
            EditorGUILayout.PropertyField(associatedColorProp, new GUIContent("Color Option"));
            
        }

        else if(script.buttonType == StageOneOptionObject.Types.Texture_New)
        {
            EditorGUILayout.PropertyField(associatedTextureProp, new GUIContent("Texture Option"));
        }
        else if(script.buttonType == StageOneOptionObject.Types.Mesh)
        {
            EditorGUILayout.PropertyField(associatedMeshProp, new GUIContent("Mesh Option"));
        }

        else if(script.buttonType == StageOneOptionObject.Types.Texture_Attribute)
        {
            EditorGUILayout.PropertyField(associatedAttributeProp, new GUIContent("Attribute Name"));
            EditorGUILayout.PropertyField(associatedTextureProp, new GUIContent("Texture Option"));
            EditorGUILayout.PropertyField(newValueProp, new GUIContent("Attribute Value"));
        }

        serializedObject.ApplyModifiedProperties();

    }
 }