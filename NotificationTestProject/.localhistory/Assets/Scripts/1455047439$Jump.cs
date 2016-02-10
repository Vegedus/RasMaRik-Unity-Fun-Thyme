using UnityEngine;
using System.Collections;
using System;

public class Jump : MonoBehaviour
{
    void Awake()
    {
        //Starts listening for the posting of any notifications with the Anykey name. Will call "JumpNow" if one such is posted
        NotificationCenter.AddObserver((Action<int>)JumpNow, Notification.AnyKey);
        
    }

    private void JumpNow(int j)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
    }
}
