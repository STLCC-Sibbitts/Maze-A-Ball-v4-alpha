using UnityEngine;
using System.Collections;

public class DEBUG_BroadcastGetInput : MonoBehaviour 
{
	// Update is called once per frame
	void Update() 
	{
		//DEBUG: displays the current value of the following variables
        Debug.Log(
                  "Input -- Vertical : " + Input.GetAxis("Vertical")
                  + " Horizontal : " + Input.GetAxis("Horizontal")
                  + " -- Velocity : " + rigidbody.velocity.ToString()
                  );//END DEBUG
	}//END Update
}//END Class
