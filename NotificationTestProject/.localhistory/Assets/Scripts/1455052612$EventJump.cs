using UnityEngine;
using System.Collections;
using j =Event.instance;
public class EventJump : MonoBehaviour {

    void Awake()
    {
        Event.instance.AnyKeyPressed.AddListener(JumpNow);
    }

    private void JumpNow(int j)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 2);
    }
}
