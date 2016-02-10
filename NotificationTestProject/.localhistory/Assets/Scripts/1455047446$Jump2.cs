using UnityEngine;
using System.Collections;

public class Jump2 : MonoBehaviour {

    void Awake()
    {
        Notification.AnyKeyUnity.AddListener(JumpNow);
    }

    private void JumpNow(int j)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 4);
    }
}
