/* 
 * This scipt will give the ball a little extra push to help navigate the turns a little better, and produce much faster gameplay without sacrificing rotation distance on the game board
 */


using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    public float pushAmount = 1.0f; //the factor for movement speed. Basically a way to control how much the player moves
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");                 //get horizontal input
        float moveVertical = Input.GetAxis("Vertical");                     //get vertical input 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //set the movement vector
        rigidbody.AddForce(movement * pushAmount * Time.deltaTime);         //vector3 * movement limiter (public variable) * internal game clock(in seconds for sync)
    }//END FixedUpdate
	
    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Pickup")
		{
            Destroy(other);
			Debug.Log("Player Completed the Level");
            
            //Load a new level here

		}
	}//END OnTriggerEnter
}//END Class