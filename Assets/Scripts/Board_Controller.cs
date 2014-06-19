using UnityEngine;
using System.Collections;

public class Board_Controller : MonoBehaviour
{
    public float BoardMaximumAngle = 9.0f;     //Board MaxAngle and Speed have been made private so that the values stay consistant among gameboard-model versions.
    public float BoardMovementSpeed = 0.45f;   //Trial and error was used to determine the best possible to angle and speed. To adjust or optimize, make these variables public and recalibrate 
    private float moveHorizontal;               //Stores horizontal input
    private float moveVertical;                 //Stores vertical input

    void Update()//Update, so the engine reads the input slower
    {
        //get input
        moveHorizontal = Input.GetAxis("Horizontal");   //Accept and store the horizontal input
        moveVertical = Input.GetAxis("Vertical");       //Accept and store the vertical input
        
        //move board
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //Define the input as a vector3 movement.

        rigidbody.velocity = movement * BoardMaximumAngle * BoardMovementSpeed;                     //Sets the velocity at which the board will rotate
        rigidbody.rotation = Quaternion.Euler(rigidbody.velocity.x, 0.0f, rigidbody.velocity.z);   //Actuates the rotation, with the set angles, moving at the determined velocty.
 
        //DEBUG: displays the current value of the following variables
        Debug.Log(  "Input (vertical : " + moveVertical.ToString()
                +   " horizontal : " + moveHorizontal.ToString() + ")"
                +   " -- velocity : " + rigidbody.velocity.ToString());
    }//END Update
}//END Class