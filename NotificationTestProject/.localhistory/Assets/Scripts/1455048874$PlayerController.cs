using UnityEngine;
using System.Collections;
using j = Event;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey) { 
            //Post a notification, making all observers of that particular Notfication call whatever function they've got subscribed to it with the latter parameter.
            this.PostNotification(Notification.AnyKey, 5);
            //Method 2, inbuilt unity events

            Event.AnyKeyUnity.Invoke(5);
            //var j = UnityEvent.GetValidMethodInfo(this, "Update", );
        }
    }
}
