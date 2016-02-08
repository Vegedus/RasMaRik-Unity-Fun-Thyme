using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey)
            this.PostNotification(Notification.AnyKey);

    }
}
