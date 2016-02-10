using UnityEngine;
using System.Collections;
using System;

public class EventJump : MonoBehaviour {

    void OnEnable()
    {
        Event.instance.AnyKeyPressed.AddListener(JumpNow);
        Event.instance.Button.AddListener(Jump);
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 3,3);
    }

    private void JumpNow(int height)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, height);
    }
}
