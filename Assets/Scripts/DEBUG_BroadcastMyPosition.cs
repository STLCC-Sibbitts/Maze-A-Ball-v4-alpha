using UnityEngine;
using System.Collections;

public class DEBUG_BroadcastMyPosition : MonoBehaviour {
	void Update ()
    {
        //Write position in the Debug.Log
        Debug.Log("Current Position of Ball " + rigidbody.position.ToString());
	}
}
