using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //List with PowerUp ScriptableObjects, then create prefab?
    //This naming sense is now ass.
    public PowerUp powerUp;
    public ShootMechanic weapon;

    private void Start()
    {
        weapon = PlayerController.Instance.gameObject.GetComponentInChildren<ShootMechanic>();
    }

    private void Update()
    {
        gameObject.transform.LookAt(PlayerController.Instance.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            weapon.weaponSettings = powerUp;
        }
    }
}
