using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Final Exam #3
 * 
 *  Make this script inherit the PickUp Class.
 * Attach this script to the yellow arrow that is on the track
 * Override the Activate() method to:
 *      - Save the original speed of the player
 *      - increase the speed of the car to 5
 *      - Wait for 2 seconds (Write a coroutine)
 *      - Change the speed back to the originalSpeed
 * 
 */
public class SpeedPickup : PickUp
{
    public float originalSpeed;
    public float boostedSpeed;


    public override void Activate()
    {
       //Saves original Speed
        originalSpeed = player.moveSpeed;

        //Speeds the player up
        player.moveSpeed = originalSpeed + 5;

        //Starts the cooldown
        StartCoroutine(SpeedTimer());
    }

    //Returns the player back to the original speedafter 2 seconds
    IEnumerator SpeedTimer()
    {
        yield return new WaitForSeconds(2);

        player.moveSpeed = originalSpeed;
    }
}
