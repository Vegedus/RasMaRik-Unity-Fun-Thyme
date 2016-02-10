﻿using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    //Should always implement Awake to call InitializeSingleton and any other stuff
    protected abstract void Awake();

    public static T instance;

    public void InitializeSingleton(T derivedThis)
    {
        //Check if instance already exists
        if (instance == null)
            //if not, set instance to this
            instance = derivedThis;
        //If instance already exists and it's not this:
        else if (instance != derivedThis)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            MonoBehaviour.Destroy(gameObject);
        //Sets this to not be destroyed when reloading scene
        MonoBehaviour.DontDestroyOnLoad(derivedThis);
    }

}
