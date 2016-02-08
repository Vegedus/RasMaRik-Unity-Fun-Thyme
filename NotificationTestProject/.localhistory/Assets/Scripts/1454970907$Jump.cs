using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	void Awake () {
        NotificationCenter.AddObserver(Jump, Notification.AnyKey);
	}

    void Jump()
    {

    }
}
