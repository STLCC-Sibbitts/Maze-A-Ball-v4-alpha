/*
 * Rotate on the X,Y,Z Axies at the defined speeds (of 15,30,45), multiplied by the current time (delta time is used to sync to the animation's current key frames), 
 * thus starting the rotation at a random position in the Vector3.        
 */
using UnityEngine;
using System.Collections;
public class Pickup_Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //multiplying by the animation's time, creates a random starting vector3 movement
    }//END Update
}//END Class