using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPhaseTwoInfo : MonoBehaviour
{
    public float height;
    public float weight;

    [SerializeField] private float startingHeight;
    [SerializeField] private float startingWeight;

    private void Start()
    {
        height = startingHeight;
        weight = startingWeight;
    }

}
    //Fill with the remaining info you want to pass to phase two. 
