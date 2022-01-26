using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float _sensitivity=0.4f;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;
    private Vector3 rotation;
    private bool _isRotating;
    
    void Start ()
    {
        _sensitivity = 0.4f;
        rotation = Vector3.zero;
    }
    
    void Update()
    {
        if(_isRotating)
        {
            // offset
            mouseOffset = (Input.mousePosition - mouseReference);
            
            // apply rotation
            rotation.y = -(mouseOffset.x + mouseOffset.y) * _sensitivity;
            
            // rotate
            transform.Rotate(rotation);
            
            // store mouse
            mouseReference = Input.mousePosition;
        }
    }
    
    void OnMouseDown()
    {
        _isRotating = true;
        
        // store mouse
        mouseReference = Input.mousePosition;
    }
    
    void OnMouseUp()
    {
        _isRotating = false;
    }
}
