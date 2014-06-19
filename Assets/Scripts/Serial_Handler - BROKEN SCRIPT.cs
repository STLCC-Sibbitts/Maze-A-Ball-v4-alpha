/* DOES NOT WORK
 * Assembly reference not found for System.IO.Ports

using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialHandler : MonoBehaviour 
{
    public string[] arduinoInputValue; // will store the incomming packet as an array of three strings
    SerialPort arduinoStream = new SerialPort("COM3", 9600); //Start a new stream at the desginated COM port (typically COM3 or COM4)        
       
	void start()
	{
       
		arduinoStream.Open(); //Open the Serial Stream
        Debug.Log("Serial Stream Opened");
	}
    void Update () 
    {
        string nextLine = arduinoStream.ReadLine(); //Read the information
        string[] serialPacket = nextLine.Split(','); //Arduino script is serving a 3 part value (IE: x, y, z)
        
        if(serialPacket[0] != "" && serialPacket[1] != "" && serialPacket[2] != "") //Check if all values are recieved
        {
             Debug.Log("Packet Received");
        }
        
            arduinoStream.BaseStream.Flush(); //Clear the serial information
    }//END Update
}//End Class

*/