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
        scrollDirection= -Input.mouseScrollDelta.y;
        if(scrollDirection!=0)
            ZoomCamera(scrollDirection);
    }
    /// <summary>
    /// This method is used by the UI buttons for discretized zooming using the field of view. The minimum and maximum zoom are dictated by lowerBound and upperBound respectively.
    /// </summary>
    /// <param name="increment">
    /// The discrete value that the field of view will be changed by, influenced by the user-configured sensitivity.  
    /// </param>
    public void ZoomCamera(int increment)
    {
        float _fov = cameraReference.fieldOfView;
        _fov += (increment*sensitivity);
        _fov= Mathf.Clamp(_fov, lowerBound,upperBound);
        cameraReference.fieldOfView = _fov;
    }

    /// <summary>
    /// This method is used to enable continuous zooming using the scrollwheel. The minimum and maximum zoom are dictated by lowerBound and upperBound respectively.
    /// </summary>
    /// <param name="direction">
    /// The continuous value that the field of view will be changed by, influenced by the user-configured sensitivity.
    /// </param>
    private void ZoomCamera(float direction)
    {
        float _fov = cameraReference.fieldOfView;
        _fov += (direction*sensitivity);
        _fov= Mathf.Clamp(_fov, lowerBound,upperBound);
        cameraReference.fieldOfView = _fov;

        
    }
}
