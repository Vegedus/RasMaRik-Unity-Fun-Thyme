using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey) { 
            //Post a notification, making all observers of that particular Notfication call whatever function they've got subscribed to it with the latter parameter.
            this.PostNotification(Notification.AnyKey, 5);
            //Method 2, inbuilt unity events

            Notification.AnyKeyUnity.Invoke();
            var j = UnityEvent.GetValidMethodInfo(this, "Update", null);
        }
    }
}
