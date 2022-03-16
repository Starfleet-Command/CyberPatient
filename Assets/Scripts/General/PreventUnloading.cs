using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventUnloading : MonoBehaviour
{

    private void Awake()
    {
        var curObjectScripts = FindObjectsOfType<PreventUnloading>();
        if (curObjectScripts.Length > 1)
        {
                Destroy(gameObject);
                return;
        }

        DontDestroyOnLoad(this.gameObject);    
    }
    
}
