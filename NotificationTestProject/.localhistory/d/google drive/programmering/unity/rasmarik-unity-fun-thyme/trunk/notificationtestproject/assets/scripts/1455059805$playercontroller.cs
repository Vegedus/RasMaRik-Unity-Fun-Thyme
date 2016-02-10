using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey) { 
            //Post a notification, making all observers of that particular Notfication call whatever function they've got subscribed to it with the latter parameter.
            this.PostNotification(Notification.AnyKey, 3);
            //Method 2, inbuilt unity events

            //Event.instance.AnyKeyPressed.Invoke(5);
            //var j = UnityEvent.GetValidMethodInfo(this, "Update", );
        }
    }
}
