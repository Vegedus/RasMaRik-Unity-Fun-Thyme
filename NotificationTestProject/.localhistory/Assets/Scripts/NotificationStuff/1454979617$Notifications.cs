using System;

public class Notification
{
    public const string AnyKey = "AnyKey";

    public readonly Notification AnyKey2 = new Notification(typeof(Func<int>));

    private static int idIncrementer = 0;

    private int id;
    public Type methodType;
    public Notification(Type methodType)
    {
        id = idIncrementer++;
        this.methodType = methodType;
    }

}