using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleSkinMeshData : MonoBehaviour
{
    
    public Dictionary<string, ModelHotspot> hotspotDict;
    public Dictionary<HotspotTypes,ModelHotspot> typesHotspotDict;
    // Start is called before the first frame update
    void Start()
    {
        hotspotDict = new Dictionary<string, ModelHotspot>();
        typesHotspotDict = new Dictionary<HotspotTypes,ModelHotspot>();
        GetInitialHotspots(GameObject.FindWithTag("Player"));
    }


    private void GetInitialHotspots(GameObject avatarObject)
    {
        Component[] allHotspots;
        allHotspots = avatarObject.GetComponentsInChildren(typeof(ModelHotspotReferenceObject));

        foreach (ModelHotspotReferenceObject partHotspots in allHotspots)
        {
            for (int i = 0; i < partHotspots.modelHotspots.Length; i++)
            {
                if(!hotspotDict.ContainsKey(partHotspots.modelHotspots[i].meshReference.name))
                {
                    hotspotDict.Add(partHotspots.modelHotspots[i].meshReference.name,partHotspots.modelHotspots[i]);
                }

                if(!typesHotspotDict.ContainsKey(partHotspots.modelHotspots[i].key))
                {
                    typesHotspotDict.Add(partHotspots.modelHotspots[i].key,partHotspots.modelHotspots[i]);
                }
                
            }
            
        }

    }  
}



