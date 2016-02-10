using System;

public class Notification
{
    public const string AnyKey = "AnyKey";

    public const Notification AnyKey = new Notification(Func<int>)

    private static int idIncrementer = 0;

    private int id;
    public Action methodType;
    public Notification(Action methodType)
    {
        id = idIncrementer++;
        this.methodType = methodType;
    }

}