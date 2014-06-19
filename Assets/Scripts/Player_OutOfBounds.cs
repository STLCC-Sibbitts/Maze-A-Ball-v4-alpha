/*
 * If the ball falls off the board,
 * return the ball to the starting postion set in the GUI.
 */
using UnityEngine;
using System.Collections;

public class Player_OutOfBounds : MonoBehaviour
{
	public float returnThreshold;   //If the player's sphere reaches the determined Y-axis value, the ball will be returned
	public float returnMeToX;       //what is the X value for the return position
	public float returnMeToY;       //what is the Y value for the return position
	public float returnMeToZ;       //what is the Z value for the return position

    void Update()
    {   
        if (rigidbody.position.y < returnThreshold)//If the ball fell past the returnThreshold
            returnToStartPosition();
    }//END Update

    void returnToStartPosition()
    {
        transform.position = new Vector3(returnMeToX, returnMeToY, returnMeToZ);  //Return player's sphere to the default starting postion
    }//END returnToStartPosition()
}//END Class