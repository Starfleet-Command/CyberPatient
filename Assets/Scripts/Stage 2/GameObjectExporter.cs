using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
#if !UNITY_WEBGL
using Autodesk.Fbx;
using System.IO;
using UnityEditor.Formats.Fbx.Exporter;

#endif

public class GameObjectExporter: MonoBehaviour

{

    public Button exportButton;
    public GameObject avatarObject;
    private List<Object> objectsToExport;

    void Start()
    {
        Button btn = exportButton.GetComponent<Button>();
        btn.onClick.AddListener(ExportModel);
        avatarObject = GameObject.FindWithTag("Player");

        objectsToExport = new List<Object>();
        objectsToExport.Add(avatarObject);

    }

    void ExportModel()

    {
        #if !UNITY_WEBGL

        // Build the fbx scene file path

        // (player/player_data/emptySceneFromRuntime.fbx)

        string fbxFilePath = Application.dataPath;
        
        //fbxFilePath = System.IO.Path.Combine(folderName, "SubFolder");

        string dateString = System.DateTime.Now.ToString().Replace('/','_').Replace(' ', '_').Replace(':', '_');

        fbxFilePath = Path.Combine(fbxFilePath,dateString);

        fbxFilePath = Path.GetFullPath(fbxFilePath);

        Debug.Log(string.Format("The file that will be written is {0}", fbxFilePath));

        using (var fbxManager = FbxManager.Create())

        {

        FbxIOSettings fbxIOSettings = FbxIOSettings.Create(fbxManager, Globals.IOSROOT);
        // Configure the IO settings.
        fbxManager.SetIOSettings(fbxIOSettings);
        // Create the exporter
        var fbxExporter = FbxExporter.Create(fbxManager, "Exporter");
        // Initialize the exporter.
        int fileFormat = fbxManager.GetIOPluginRegistry().FindWriterIDByDescription("FBX ascii (*.fbx)");
        bool status = fbxExporter.Initialize(fbxFilePath, fileFormat, fbxIOSettings);
        
        // Check that initialization of the fbxExporter was successful
        if (!status)
        {
            Debug.LogError(string.Format("failed to initialize exporter, reason: {0}",
            fbxExporter.GetStatus().GetErrorString()));
            return;

        }

        // Create a scene
        var fbxScene = FbxScene.Create(fbxManager, "Scene");

        // create scene info
        FbxDocumentInfo fbxSceneInfo = FbxDocumentInfo.Create(fbxManager, "SceneInfo");

        // set some scene info values
        fbxSceneInfo.mTitle = "Patient Model Export";
        fbxSceneInfo.mSubject = "Exported from a Unity runtime";
        fbxSceneInfo.mAuthor = "CyberPatient Authoring Tool";
        fbxSceneInfo.mRevision = "1.0";
        fbxScene.SetSceneInfo(fbxSceneInfo);

       
        // Export the scene to the file.
        //status = fbxExporter.Export(fbxScene);
        ModelExporter.ExportObjects(fbxFilePath, objectsToExport.ToArray());
        // cleanup
        fbxScene.Destroy();
        fbxExporter.Destroy();

        }

        #endif
    }

}
