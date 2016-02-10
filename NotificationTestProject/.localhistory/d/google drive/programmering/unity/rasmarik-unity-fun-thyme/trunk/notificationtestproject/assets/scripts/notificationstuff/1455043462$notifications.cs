using System;

public class Notification
{
    public const string AnyKey = "AnyKey";

    public readonly Notification AnyKey2 = new Notification(typeof(Func<int>));

    public readonly int Anykey3 = id++;

    private static int id = 0;

    //private int id;
    public Type methodType;
    public Notification(Type methodType)
    {
      //  id = id++;
        this.methodType = methodType;
    }

}