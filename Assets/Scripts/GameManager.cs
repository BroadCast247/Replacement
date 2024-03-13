using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public HUDController HUD;

    private int _score;
    public int Score
    {
        get {return _score;}
        set
        {
            _score = value;
            HUD.scoreText.text = "Score: " + value.ToString();
        }
    }

    private int _timer;
    public int Timer
    {
        get {return _timer;}
        set
        {
            _timer = value;
            HUD.timerText.text = "Time: " + value.ToString();
        }
    }

    [SerializeField]
    private int _lives;
    public int Lives
    {
        get {return _lives;}
        set
        {
            _lives = value;
            HUD.livesText.text = "Lives: " + value.ToString();
        }
    }

    void Start()
    {
        if (!HUD)
        {
            Debug.Log("HUD reference is missing.");
        }
        Debug.Log(Score.ToString() + Timer.ToString() + Lives.ToString());
    }

    void Update()
    {
        //The 0.5 second discrepency is kind of fucking horrible. Probably try some other way.
        Timer = Mathf.RoundToInt(Time.time);
    }
}
