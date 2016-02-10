﻿using UnityEngine;
using System.Collections;
using System;

public class NotificationJump : MonoBehaviour
{
    void Awake()
    {
        //Starts listening for the posting of any notifications with the Anykey name. Will call "JumpNow" if one such is posted
        NotificationCenter.AddObserver(JumpNow, Notification.AnyKey);
        
    }

    private void JumpNow(object a, object b)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
    }
}
