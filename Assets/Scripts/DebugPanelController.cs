using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPanelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LivesUP()
    {
        GameManager.Instance.Lives++;
    }

    public void TimeUP()
    {
        GameManager.Instance.Timer++;
    }

    public void ScoreUP()
    {
        GameManager.Instance.Score++;
    }
}
