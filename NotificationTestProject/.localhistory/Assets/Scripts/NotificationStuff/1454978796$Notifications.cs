using System;

public class Notification
{
    public const string AnyKey = "AnyKey";


    private static int idIncrementer = 0;

    private int id;
    public Action methodType;
    public Notification(Action methodType)
    {
        id = id++;
    }

}