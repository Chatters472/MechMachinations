using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls the mechs ability to move
public class MechMovement : MonoBehaviour
{
    //Rotations to hold the upper and lower spine bones seperate from the parent spine bone
    [SerializeField] Transform lowerRotation;
    [SerializeField] Transform upperRotation;
    //Lower and upper spine bones
    [SerializeField] Transform lowerSpine;
    [SerializeField] Transform upperSpine;
    //Torso and leg rotation speed 
    [SerializeField] float torsoSpeed;
    [SerializeField] float legSpeed;
    //Check if speed has already been reduced
    private bool torsoSpeedReduced;
    private bool legSpeedReduced;
    //Body part health
    [SerializeField] BodyPart head;
    [SerializeField] BodyPart torso;
    [SerializeField] BodyPart leftArm;
    [SerializeField] BodyPart rightArm;
    [SerializeField] BodyPart leftLeg;
    [SerializeField] BodyPart rightLeg;
    // Start is called before the first frame update
    void Start()
    {
        //Setting initial value
        torsoSpeedReduced = false;
        legSpeedReduced = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Reduces torso speed if an arm has been destroyed
        if ((leftArm.getDestroyed() || rightArm.getDestroyed()) || !torsoSpeedReduced)
        {
            torsoSpeed *= 0.5f;
            torsoSpeedReduced = true; //will no longer loop through and keep reducing torso speed
        }

        //Reduces torso speed if an arm has been destroyed
        if ((leftLeg.getDestroyed() || rightLeg.getDestroyed()) || !legSpeedReduced)
        {
            legSpeed *= 0.5f;
            legSpeedReduced = true; //will no longer loop through and keep reducing leg speed
        }
    }
}
