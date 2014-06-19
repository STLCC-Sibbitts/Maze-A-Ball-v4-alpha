using UnityEngine;
using System.Collections;

public class Game_Timer : MonoBehaviour {

    public float timeActual = 0;	//this is the real time. Used for keeping score. Made public so the value is displayed in the unity editor
    private float timeRounded; //it is important to keep the timer GUI(an integer), the GUI Text (a string), and the actual time score (a float) separated from one another. Timing is everything ;)
  
    void Update()
    {
        timeActual += Time.deltaTime;  //Time.deltaTime is the internal game clock provided in seconds
        timeRounded = Mathf.Round(timeActual); //Rounds to the nearest integer without effecting the raw timer
        guiText.text = "Current Time : " + timeRounded.ToString(); //displaying the timeRounded, not actualTime
    }
}
