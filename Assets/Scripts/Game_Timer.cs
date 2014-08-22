using UnityEngine;
using System.Collections;

public class Game_Timer : MonoBehaviour {

    public float timeActual = 0;	//this is the real time. Used for keeping score. Made public so the value is displayed in the unity editor
    private float timeRounded; //it is important to keep the timer GUI(an integer), the GUI Text (a string), and the actual time score (a float) separated from one another.
  
    void Update()
    {
        timeActual += Time.deltaTime;  //Time.deltaTime is the internal game clock provided in seconds
        timeRounded = Mathf.Round(timeActual); //Rounds to the actual time to the nearest integer
        guiText.text = "Current Time : " + timeRounded.ToString(); //displaying the timeRounded, not actualTime
    }//END Update

	void LevelEnd()	//EVENT LISTENER
	{
		//Stop timer and record the score		
	}//END LevelEnd
}//END Class
