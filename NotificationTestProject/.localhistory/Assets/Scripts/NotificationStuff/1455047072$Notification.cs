using System;
using UnityEngine.Events;

public class Notification
{
    public const string AnyKey = "AnyKey";

    public readonly Notification AnyKey2 = new Notification(typeof(Func<int>));

    public static readonly int Anykey3 = id++;
    public static GenericEvent AnyKeyUnity = new GenericEvent();

    [Serializable]
    public class GenericEvent : UnityEvent<bool> { }

    private static int id = 0;

    //private int id;
    public Type methodType;
    public Notification(Type methodType)
    {
        //  id = id++;
        this.methodType = methodType;
    }
}

//I've created custom buttons in Unity's UI and have added my own UnityEvents to these buttons so that I can assign functions to call on click events and such.I'm doing this with:
//public class ToggleEvent : UnityEvent<bool> { }

//[SerializeField]
//public ToggleEvent clickEvent;
//With the event calls looking simply like:
//public void ButtonEvent(bool value) { }
//This works great in the editor but when I call
//clickEvent.Invoke(true);
//...it'll only pass whatever the bool value is marked off in the editor, not what's actually being passed.How do I override what's being set in the editor and pass my own variables in code?
//               clickEvent.AddListener(ButtonEvent);
//clickEvent.Invoke(true);