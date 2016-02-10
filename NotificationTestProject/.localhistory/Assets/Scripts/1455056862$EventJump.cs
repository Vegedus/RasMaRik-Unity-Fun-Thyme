using UnityEngine;
using System.Collections;

public class EventJump : MonoBehaviour {

    void Awake()
    {
        Event.instance.AnyKeyPressed.AddListener(JumpNow);
    }

    private void JumpNow()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, height);
    }
}
