using UnityEngine;
using System.Collections;

public class DEBUG_BroadcastNewLevel : MonoBehaviour {

	void OnLevelWasLoaded(int level) //EVENT LISTENER
	{
		level++;	//Scenes are currently loaded in order, begining with 0 (level 1 == 0, ect.). That is not what I need displayed
		Debug.Log ("Loaded Level  " + level.ToString());
	}
}//END class