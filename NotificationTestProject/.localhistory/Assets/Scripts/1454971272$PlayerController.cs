using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    void Update()
    {
        if (Input.anyKey)
            Debug.Log("A key or mouse click has been detected");

    }
}
