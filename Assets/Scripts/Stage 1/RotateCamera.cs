using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class RotateCamera : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float _sensitivity=0.4f;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;
    private Vector3 rotation;
    private bool _isRotating;
    [SerializeField] private GameObject objectToRotate;
    

    void Start ()
    {
        _sensitivity = 0.4f;
        rotation = Vector3.zero;

        if(objectToRotate == null)
        {
            objectToRotate = GameObject.FindWithTag("Player");
        }
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
            objectToRotate.transform.Rotate(rotation);
            
            // store mouse
            mouseReference = Input.mousePosition;
        }
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _isRotating = true;
        
        // store mouse
        mouseReference = Input.mousePosition;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        _isRotating = false;
    }
}
