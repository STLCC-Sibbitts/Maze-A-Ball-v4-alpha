using UnityEngine;
using System.Collections;

public class Player_Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position;    //offset == the camera's y-axis value
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;    //offset + the current y-axis value of the player GameObject
    }
}//END Class
