using UnityEngine;
using System.Collections;

public static class Event {

    public static readonly int Anykey3 = id++;
    public static GenericEvent AnyKeyUnity = new GenericEvent();

    [Serializable]
    public class GenericEvent : UnityEvent<int> { }
}
