using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;

[RequireComponent(typeof(Button))]
public class MetadataExporter : MonoBehaviour, IPointerDownHandler {
    
    private AvatarPhaseTwoInfo avatarInfoScript;
    

#if UNITY_WEBGL && !UNITY_EDITOR
    //
    // WebGL
    //

    private void Start()
    {
        avatarInfoScript = GameObject.FindWithTag("Player").GetComponent<AvatarPhaseTwoInfo>();

    }

    [DllImport("__Internal")]
    private static extern void DownloadFile(string gameObjectName, string methodName, string filename, byte[] byteArray, int byteArraySize);

    // Broser plugin should be called in OnPointerDown.
    public void OnPointerDown(PointerEventData eventData) {

        string _data = avatarInfoScript.PrepDataForExport();
        var bytes = Encoding.UTF8.GetBytes(_data);
        string dateString = System.DateTime.Now.ToString().Replace('/','_').Replace(' ', '_').Replace(':', '_');
        DownloadFile(gameObject.name, "OnFileDownload", "case_export_"+dateString+".txt", bytes, bytes.Length);
    }

    // Called from browser
    public void OnFileDownload() {
    }

#else
    //
    // Standalone platforms & editor
    //
    public void OnPointerDown(PointerEventData eventData) { }

    // Listen OnClick event in standlone builds
    void Start() {
        avatarInfoScript = GameObject.FindWithTag("Player").GetComponent<AvatarPhaseTwoInfo>();
        var button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick() {

        string dateString = System.DateTime.Now.ToString().Replace('/','_').Replace(' ', '_').Replace(':', '_');
        string _data = avatarInfoScript.PrepDataForExport();
        
        var path = StandaloneFileBrowser.SaveFilePanel("Title", "", "case_export_"+dateString, "txt");
        if (!string.IsNullOrEmpty(path)) {
            File.WriteAllText(path, _data);
        }
    }

#endif
}