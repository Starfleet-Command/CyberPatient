using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnHover : MonoBehaviour
{
    [SerializeField] private GameObject objectToShow;


    public void ShowObject()
    {
        objectToShow.SetActive(true);
    }

    public void HideObject()
    {
        objectToShow.SetActive(false);
    }   

}
