﻿using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Event : Singleton<Event>
{
    //Could alternatively simply be static, rather than a singleton, but this enables doing stuff in the inspector
    #region Specific events, posted to and listened to in nigh-all classes.  Defined here for easy and decoupled access.
    public EventInt AnyKeyPressed = new EventInt();
    #endregion

    #region Singleton stuff
    protected override void Awake()
    {
        InitializeSingleton(this);
    }
    #endregion

    public void invokeByEvent(UnityEvent j)
    {
        j.Invoke();
    }

    //Used for invoking directly from other unityEvents. Hardcoded strings & reflection 
    //is bad though (can break by refactoring), so only for the lazy.
    public void invokeByName(String eventName)
    {
        FieldInfo field = typeof(Event).GetField(eventName);
        var fieldVal = field.GetValue(this);
        ((UnityEvent)fieldVal).Invoke();
    }

    #region Extensions to UnityEvents, enabling of passing various parameters 
    [Serializable]
    public class EventInt : UnityEvent<int> { }
    [Serializable]
    public class EventBool : UnityEvent<bool> { }
    [Serializable]
    public class EventString : UnityEvent<string> { }
    [Serializable]
    public class EventFloat : UnityEvent<float> { }
    [Serializable]
    public class EventVec2 : UnityEvent<Vector2> { }
    [Serializable]
    public class EventVec3 : UnityEvent<Vector3> { }
    [Serializable]
    //Good for inversion of control? Bad for decoupling?
    public class EventMonobehaviour : UnityEvent<MonoBehaviour> { }
    [Serializable]
    public class EventGameObject : UnityEvent<GameObject> { }
    [Serializable]
    public class EventComponent : UnityEvent<Component> { }
    [Serializable]

    #region Generic UnityEvent extensions, for when you cannot be bothered to make one specific for the method
    public class EventGeneric : UnityEvent<object> { }
    [Serializable]
    public class EventGenericTwo : UnityEvent<object, object> { }
    [Serializable]
    public class EventGenericThree : UnityEvent<object, object, object> { }
    [Serializable]
    public class EventGenericFour : UnityEvent<object, object, object, object> { }


    #endregion
    #endregion
}
