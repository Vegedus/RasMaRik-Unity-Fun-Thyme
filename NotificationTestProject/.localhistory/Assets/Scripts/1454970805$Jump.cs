using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	void Awake () {
	    NotificationCenter.AddObserver(Jump,AnyKey)
	}

    void Jump()
    {

    }
}
