using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : BaseMenu
{
    //No friend classes in C#.
    public Text scoreText;
    public Text timerText;
    public Text livesText;

    void Start()
    {
        Text[] texts = GetComponentsInChildren<Text>();
        //Apparently texts won't be null even if there's no components found, it would just be an empty array.
        if (texts.Length != 0)
        {
            foreach (Text t in texts)
            {
                switch (t.name)
                {
                    case "Score Text":
                        scoreText = t;
                        break;
                    case "Timer Text":
                        timerText = t;
                        break;
                    case "Lives Text":
                        livesText = t;
                        break;
                    default:
                        Debug.LogWarning($"{t} is an unexpected parameter.");
                        break;
                }
            }
        }
    }
}
