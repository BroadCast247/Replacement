using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract meaning can only be derived from.
//T meaning variable variable.
//When calling a Game Object, check if it exists, if not then instantiate it.
public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    static T instance;
    public static T Instance
    {
        get
        {
            if (!instance)
                instance = FindObjectOfType<T>();
            //If not found, make one.
            if (!instance)
            {
                GameObject obj = new GameObject();
                obj.name = typeof(T).Name;
                instance = obj.AddComponent<T>();
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (!instance)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
}