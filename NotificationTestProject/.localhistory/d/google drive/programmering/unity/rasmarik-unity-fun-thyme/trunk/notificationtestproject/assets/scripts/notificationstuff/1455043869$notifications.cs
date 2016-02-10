using System;
using UnityEngine.Events;

public class Notification
{
    public const string AnyKey = "AnyKey";

    public readonly Notification AnyKey2 = new Notification(typeof(Func<int>));

    public static readonly int Anykey3 = id++;
    public static GenericEvent<int> AnyKeyUnity;

    public class GenericEvent<T> : UnityEvent {}

    private static int id = 0;

    //private int id;
    public Type methodType;
    public Notification(Type methodType)
    {
        //  id = id++;
        this.methodType = methodType;
    }

}