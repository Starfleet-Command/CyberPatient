using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    public Camera cameraReference;
    public int lowerBound;
    public int upperBound;
    public float sensitivity = 0.3f;

    private float scrollDirection;

    // Start is called before the first frame update
    void Start()
    {
        if(cameraReference == null)
        {
            cameraReference = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        scrollDirection= Input.mouseScrollDelta.y;
        if(scrollDirection!=0)
            ZoomCamera(scrollDirection);
    }

    private void ZoomCamera(int increment)
    {
        cameraReference.fieldOfView += increment;
    }

    private void ZoomCamera(float direction)
    {
        float _fov = cameraReference.fieldOfView;
        _fov += (direction*sensitivity);
        _fov= Mathf.Clamp(_fov, lowerBound,upperBound);
        Debug.Log(""+_fov);
        cameraReference.fieldOfView = _fov;

        
    }
}
