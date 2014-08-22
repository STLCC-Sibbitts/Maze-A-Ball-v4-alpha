/* 
 * This scipt will give the ball a little extra push to help navigate the turns a little better, and produce much faster gameplay without sacrificing the game board's rotational angle
 */
using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    public float pushAmount = 3.0f; //the factor for movement speed.	
	public int nextLevel = 1;	//set this value to the next level number, starting with level 1 (NOT 0)

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");		//get horizontal input
        float moveVertical = Input.GetAxis("Vertical");         //get vertical input 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //set the movement vector
        rigidbody.AddForce(movement * pushAmount * Time.deltaTime);         //vector3 * movement limiter (the pushAmmount) * internal game clock (in seconds, not frames, to sync)
    }//END FixedUpdate

	//EVENT LISTENERS
    void OnTriggerEnter(Collider targetOfCollision)
	{
		Debug.Log ("Ball has collided with something");
		if (targetOfCollision.gameObject.tag == "Pickup")
		{
			targetOfCollision.gameObject.SetActive(false);	//Remove pickup from the board
			Debug.Log("Player Completed the Level");
			BroadcastMessage("LevelEnd", nextLevel); //Initiate LevelEnd event
		}
	}//END OnTriggerEnter
	void LevelEnd()
	{	
		//Load a new level here
		Application.LoadLevel("Level " + nextLevel);
	}//END LevelEnd
}//END Class