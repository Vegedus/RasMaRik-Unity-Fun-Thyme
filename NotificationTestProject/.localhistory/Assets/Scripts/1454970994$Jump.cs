using UnityEngine;
using System.Collections;
using System;

public class Jump : MonoBehaviour {
	void Awake () {
        NotificationCenter.AddObserver(Jump, Notification.AnyKey);
	}

    private void JumpNow(object sender, object jumpHeight)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpHeight);
    }
}
