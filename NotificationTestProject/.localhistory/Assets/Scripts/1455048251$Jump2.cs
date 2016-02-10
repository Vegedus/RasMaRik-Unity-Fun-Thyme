using UnityEngine;
using System.Collections;

public class EventJump : MonoBehaviour {

    void Awake()
    {
        Event.AnyKeyUnity.AddListener(JumpNow);
    }

    private void JumpNow(int j)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
    }
}
