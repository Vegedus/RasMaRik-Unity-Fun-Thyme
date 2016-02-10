using UnityEngine;

public class Singleton : MonoBehaviour
{
    public void Initialize(MonoBehaviour instance, MonoBehaviour self)
    {
        //Check if instance already exists
        if (instance == null)
            //if not, set instance to this
            instance = self;
        //If instance already exists and it's not this:
        else if (instance != self)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            MonoBehaviour.Destroy(gameObject);
        //Sets this to not be destroyed when reloading scene
        MonoBehaviour.DontDestroyOnLoad(self);
    }

}
