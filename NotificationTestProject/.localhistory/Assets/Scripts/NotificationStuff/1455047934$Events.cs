using UnityEngine;
using UnityEngine.Events;

public static class Event {
    public static EventInt AnyKeyUnity = new EventInt();

    #region Extensions to UnityEvents, enabling of passing various parameters 

    [System.Serializable]
    public class EventInt : UnityEvent<int> { }
    public class EventBool : UnityEvent<bool> { }
    public class EventString : UnityEvent<string> { }
    public class EventFloat : UnityEvent<float> { }
    public class EventVec2: UnityEvent<Vector2> { }
    public class EventInt : UnityEvent<Vector3> { }
    public class EventGeneric : UnityEvent<object> { }
    public class EventGenericTwo : UnityEvent<object,object> { }
    public class EventGenericThree : UnityEvent<object, object, object> { }
    #endregion
}
