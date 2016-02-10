﻿using UnityEngine;
using System.Collections;
using System;

public class Jump : MonoBehaviour
{
    void Awake()
    {
        //Starts listening for the posting of any notifications with the Anykey name. Will call "JumpNow" if one such is posted
        NotificationCenter.AddObserver(Func<String,String>JumpNow, Notification.AnyKey);
        
    }

    private void JumpNow()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, (in);
    }
}
