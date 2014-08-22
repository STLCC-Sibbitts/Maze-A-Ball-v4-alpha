/*
 * Some code to help debug the game
 */

using UnityEngine;
using System.Collections;

public class DEBUG_GodKeys : MonoBehaviour 
{

	public float endOfLevelPositionX = 18.0f;
	public float endOfLevelPositionZ = -40.0f;

	void FixedUpdate ()
    {
		//send ball to the goal
        if (Input.GetKey(KeyCode.Alpha0)==true) 
            transform.position = new Vector3 (endOfLevelPositionX, 100.0f, endOfLevelPositionZ);
        
		//send ball to the start
		if (Input.GetKey(KeyCode.R) == true)    
            transform.position = new Vector3(40, 115, 40);

		//Goto level 1
		if (Input.GetKey (KeyCode.Alpha1) == true)
			Application.LoadLevel(0);

		//Goto level 2
		if (Input.GetKey (KeyCode.Alpha2) == true)
			Application.LoadLevel (1);
			
	}//END FixedUpdate
}//END Class

