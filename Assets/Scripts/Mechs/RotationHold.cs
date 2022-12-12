using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script holds the rotation of the top and botton spine bones
//so that the rotation of the parent spine does not cause them to rotate
public class RotationHold : MonoBehaviour
{
    [SerializeField] Transform lowerSpine;
    [SerializeField] Transform upperSpine;
    [SerializeField] Transform lowerRotation;
    [SerializeField] Transform upperRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        lowerSpine.rotation = lowerRotation.rotation;
        upperSpine.rotation = upperRotation.rotation;
    }
}
