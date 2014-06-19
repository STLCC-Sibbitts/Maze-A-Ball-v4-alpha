/*
 * Some code to help debug the game
 */

using UnityEngine;
using System.Collections;

public class DEBUG_GodKeys : MonoBehaviour 
{
	void Update ()
    {
        if (Input.GetKey(KeyCode.Alpha0)==true) //send ball to the goal
            transform.position = new Vector3 (28.0f, 95.0f, -35.0f);
        if (Input.GetKey(KeyCode.R) == true)    //send ball to the start
            transform.position = new Vector3(40, 115, 40);
	}
}
