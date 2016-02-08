using UnityEngine;
using System.Collections;
using System;

public class Jump : MonoBehaviour {
	void Awake () {
        NotificationCenter.AddObserver(Jump, Notification.AnyKey);
	}

    private void Jump(object sender, object jumpHeight)
    {
        throw new NotImplementedException();
    }
}
