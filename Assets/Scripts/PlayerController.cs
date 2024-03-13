using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class PlayerController : Singleton<PlayerController>
{

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        GameManager.Instance.Lives = 3;
    }

    void Update()
    {
        Move();
    }

    public float rotationDegree;
    public float SPD;

    void Move()
    {
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E))
        {
            return;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0, -rotationDegree, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0, rotationDegree, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * SPD * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * SPD * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward * SPD * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * SPD * Time.deltaTime);
        }
    }
}
