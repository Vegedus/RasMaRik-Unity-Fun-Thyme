using UnityEngine.Events;

public static class Event {
    public static GenericEvent AnyKeyUnity = new GenericEvent();

    #region Extensions to UnityEvents, for passing various parameters

    [System.Serializable]
    public class GenericEvent : UnityEvent<int> { }
    #endregion
}
