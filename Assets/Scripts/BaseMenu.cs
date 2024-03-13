using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMenu : MonoBehaviour
{
    public enum MenuID
    {
        MainMenu = 0,
        PauseMenu = 1,
        HUD = 2,
    }

    void Start()
    {

    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
