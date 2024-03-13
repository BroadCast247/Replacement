using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : BaseEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make it LOS instead.
        if ((PlayerController.Instance.transform.position - gameObject.transform.position).magnitude <= 10)
        {

        }
    }
}
