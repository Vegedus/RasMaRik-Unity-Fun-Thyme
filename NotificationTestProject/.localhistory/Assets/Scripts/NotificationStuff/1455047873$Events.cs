using UnityEngine.Events;

public static class Event {
    public static EventInt AnyKeyUnity = new EventInt();

    #region Extensions to UnityEvents, enabling of passing various parameters 

    [System.Serializable]
    public class EventInt : UnityEvent<int> { }
    public class EventBool : UnityEvent<bool> { }
    public class EventString : UnityEvent<String> { }
    public class EventInt : UnityEvent<int> { }
    public class EventInt : UnityEvent<int> { }
    public class EventInt : UnityEvent<int> { }
    public class EventGeneric : UnityEvent<object> { }
    public class EventGenericTwo : UnityEvent<object,object> { }
    public class EventGenericThree : UnityEvent<object, object, object> { }
    #endregion
}
