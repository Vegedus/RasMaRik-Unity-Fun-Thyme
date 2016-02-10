using UnityEngine;
using System.Collections;

public class EventJump : MonoBehaviour {

    void Awake()
    {
        Event.AnyKeyPressed.AddListener(JumpNow);
    }

    private void JumpNow(int j)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 2);
        Debug.Log("Event:"+Profiler.GetRuntimeMemorySize(Event.AnyKeyPressed));
    }
}
