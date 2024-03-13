using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMechanic : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;

    public PowerUp weaponSettings;
    private SpriteRenderer sr;
    private float attackTime;

    private BaseEnemy enemy;

    void Start()
    {
        Cursor.visible = true;
        sr = GetComponent<SpriteRenderer>();
        attackTime = weaponSettings.ROF;
    }

    void Update()
    {
        Shoot();
    }

    private void OnValidate()
    {
        sr.sprite = weaponSettings.weaponSprite;
        attackTime = weaponSettings.ROF;
        Debug.Log("INSERTION");
    }

    void Shoot()
    {
        screenPosition = Input.mousePosition;

        //ScreenPoint(screenPosition) is a point along the raycast starting from Camera position.
        Ray hitScan = Camera.main.ScreenPointToRay(screenPosition);

        //Apparently this doesn't accomodate timescale changes?
        if (Time.time >= attackTime)
        {
            attackTime = Time.time + weaponSettings.ROF;
            //If LeftClick + RayCastHit
            //&& animation frame ==...
            if (Input.GetKey(KeyCode.Mouse0) && Physics.Raycast(hitScan, out RaycastHit hitData))
            {
                Debug.DrawRay(hitScan.origin, hitScan.direction * 10, Color.red);
                if (hitData.collider.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log("HIT");
                    //Play shoot animation?
                    //Create a sprite with an explosion animation that transforms to a raycasted position?
                    //Preload a bunch of explosion sprites? Can be calculated to not exceed possible ROF.
                    enemy = hitData.collider.gameObject.GetComponent<BaseEnemy>();
                    enemy.Suffer(weaponSettings.ATK);
                }
            }
        }
    }
}