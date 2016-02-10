using UnityEngine;
using System.Collections;

public class EventJump : MonoBehaviour {

    void OnEnable()
    {
        Event.instance.AnyKeyPressed.AddListener(JumpNow);
    }

    private void JumpNow(int height)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, height);
    }
}
