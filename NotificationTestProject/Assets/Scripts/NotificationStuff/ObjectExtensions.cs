using UnityEngine;
using System;
using System.Collections;
using Handler = System.Action<System.Object, System.Object>;

/// <summary>
/// Due to the "this object" part of the method, these methods extends the functionality of
///  every "object", so that they can call these methods by going this.[methodname]([parameters, excluding obj])
/// </summary>
public static class NotificationExtensions
{
    public static void PostNotification(this object obj, string notificationName)
    {
        NotificationCenter.instance.PostNotification(notificationName, obj);
    }

    public static void PostNotification(this object obj, string notificationName, object e)
    {
        NotificationCenter.instance.PostNotification(notificationName, obj, e);
    }

    public static void AddObserver(this object obj, Handler handler, string notificationName)
    {
        NotificationCenter.AddObserver(handler, notificationName);
    }

    public static void AddObserver(this object obj, Handler handler, string notificationName, object sender)
    {
        NotificationCenter.AddObserver(handler, notificationName, sender);
    }

    public static void RemoveObserver(this object obj, Handler handler, string notificationName)
    {
        NotificationCenter.instance.RemoveObserver(handler, notificationName);
    }

    public static void RemoveObserver(this object obj, Handler handler, string notificationName, System.Object sender)
    {
        NotificationCenter.instance.RemoveObserver(handler, notificationName, sender);
    }
}