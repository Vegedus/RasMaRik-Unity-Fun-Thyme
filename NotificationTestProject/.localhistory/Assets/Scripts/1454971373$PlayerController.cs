using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey)
            //Post a notification, making all observers of that particular Notfication call whatever function they've got subscribed to it.
            this.PostNotification(Notification.AnyKey, 10);

    }
}
