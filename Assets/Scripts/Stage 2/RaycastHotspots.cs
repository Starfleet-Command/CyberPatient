using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHotspots : MonoBehaviour
{
    private StageTwoStaticData levelData;
    [SerializeField] private float timeBetweenRaycasts;
    private bool isRaycastReady= true;
    private bool raycastHitLastFrame= false;

    // Start is called before the first frame update
    void Start()
    {
        levelData = StageTwoStaticData.Instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRaycastReady)
            SendRaycast();
    }

    public void SendRaycast()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
        {   
            TryPlayHotspotSound(hit.collider.gameObject);
        }
        else if(raycastHitLastFrame)
        {
           levelData.avatarFunctionsScript.StopSound();
           raycastHitLastFrame = false; 
        }

        StartCoroutine("raycastCooldown");
    }

    void TryPlayHotspotSound(GameObject collidedObject)
    {
        ModelHotspot hotspotInfo;
        if(levelData.skinDataScript.hotspotDict.TryGetValue(collidedObject.name, out hotspotInfo))
        {
            raycastHitLastFrame = true;
            levelData.avatarFunctionsScript.PlaySound(hotspotInfo.soundClip,1f,1f);
        }
    }

    IEnumerator raycastCooldown()
    {
        isRaycastReady = false;
        yield return new WaitForSeconds(timeBetweenRaycasts);
        isRaycastReady = true;
    }
}
