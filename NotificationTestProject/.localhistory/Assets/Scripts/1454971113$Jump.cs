﻿using UnityEngine;
using System.Collections;
using System;

public class Jump : MonoBehaviour {
	void Awake () {
        NotificationCenter.AddObserver(JumpNow, Notification.AnyKey);
	}

    private void JumpNow(object sender, object jumpHeight)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, (int)jumpHeight);
    }
}
