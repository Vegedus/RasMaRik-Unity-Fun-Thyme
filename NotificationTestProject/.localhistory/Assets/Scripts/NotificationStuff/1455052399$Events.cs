﻿using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{
    #region Specific events, posted to and listened to in the system.
    public EventInt AnyKeyPressed;
    #endregion

    public Event instance;

    #region Extensions to UnityEvents, enabling of passing various parameters 
    [System.Serializable]
    public class EventInt : UnityEvent<int> { }
    [System.Serializable]
    public class EventBool : UnityEvent<bool> { }
    [System.Serializable]
    public class EventString : UnityEvent<string> { }
    [System.Serializable]
    public class EventFloat : UnityEvent<float> { }
    [System.Serializable]
    public class EventVec2 : UnityEvent<Vector2> { }
    [System.Serializable]
    public class EventVec3 : UnityEvent<Vector3> { }
    [System.Serializable]
    //Good for inversion of control? Bad for decoupling?
    public class EventMonobehaviour : UnityEvent<MonoBehaviour> { }
    [System.Serializable]
    public class EventGameObject : UnityEvent<GameObject> { }
    [System.Serializable]
    public class EventComponent : UnityEvent<Component> { }
    [System.Serializable]

    #region Generic UnityEvent extensions, for when you cannot be bothered to make one specific for the method
    public class EventGeneric : UnityEvent<object> { }
    [System.Serializable]
    public class EventGenericTwo : UnityEvent<object, object> { }
    [System.Serializable]
    public class EventGenericThree : UnityEvent<object, object, object> { }
    [System.Serializable]
    public class EventGenericFour : UnityEvent<object, object, object, object> { }

    #endregion
    #endregion
}
