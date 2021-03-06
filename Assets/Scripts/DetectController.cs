using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectController : GameBehaviour
{
    public PlayerController thePlayer;
    void Start()
    {
        
    }

    void Update()
    {
        //Detect Mouse Input
        if(Input.GetMouseButton(0) || Input.GetMouseButton(2))
        {
            thePlayer.useController = false;
        }
        if (Input.GetAxisRaw("Mouse X") != 0.0f || Input.GetAxisRaw("Mouse Y") != 0.0f)
        {
            thePlayer.useController = false;
        }

        //Detect Controller Input
        if(Input.GetAxisRaw("RHorizontal") != 0.0f || Input.GetAxis("Vertical") != 0.0f)
        {
            thePlayer.useController = true;
        }
        if(Input.GetKey(KeyCode.Joystick1Button0) ||
           Input.GetKey(KeyCode.Joystick1Button1) ||
           Input.GetKey(KeyCode.Joystick1Button2) ||
           Input.GetKey(KeyCode.Joystick1Button3) ||
           Input.GetKey(KeyCode.Joystick1Button4) ||
           Input.GetKey(KeyCode.Joystick1Button5) ||
           Input.GetKey(KeyCode.Joystick1Button6) ||
           Input.GetKey(KeyCode.Joystick1Button7) ||
           Input.GetKey(KeyCode.Joystick1Button8) ||
           Input.GetKey(KeyCode.Joystick1Button9) ||
           Input.GetKey(KeyCode.Joystick1Button10))
        {
            thePlayer.useController = true;
        }

    }
}
