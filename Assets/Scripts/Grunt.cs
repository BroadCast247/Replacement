using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : BaseEnemy
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

//Loses hp while being shot at.
//Preferably loses hp everytime a certain frame of the gunshot animation plays.