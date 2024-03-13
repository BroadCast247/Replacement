using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootMechanic : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;

    [SerializeField] private GameObject subMachineGunPrefab;
    
    [SerializeField] private Weapon currWeapon;
    
    private float attackTime;
    private BaseEnemy enemy;

    void Start()
    {
        Cursor.visible = true;
        attackTime = currWeapon.GetROF();
    }

    void Update()
    {
        bool isShooting = Input.GetKey(KeyCode.Mouse0);
        if (!isShooting) return;

        attackTime -= Time.deltaTime;
        if (attackTime > 0)
        {
            return;
        }
        else
        {
            attackTime = currWeapon.GetROF();
        }

        Debug.LogFormat("Applying Damage: {0}", currWeapon.GetAttack());
        Shoot(currWeapon.GetAttack());
    }

    public void ChangeWeapon(Weapon newWeapon)
    {
        // TO DO: Instantiate weapon
        currWeapon = newWeapon;
    }

    private void OnValidate()
    {
        //sr.sprite = weaponSettings.weaponSprite;
        //attackTime = weaponSettings.ROF;
        Debug.Log("INSERTION");
    }

    void Shoot(int Damage)
    {
        screenPosition = Input.mousePosition;

        //ScreenPoint(screenPosition) is a point along the raycast starting from Camera position.
        Ray hitScan = Camera.main.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(hitScan, out RaycastHit hitData))
        {
            Debug.DrawRay(hitScan.origin, hitScan.direction * 10, Color.red);
            if (hitData.collider.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("HIT");
                //Play shoot animation?
                //Create a sprite with an explosion animation that transforms to a raycasted position?
                //Preload a bunch of explosion sprites? Can be calculated to not exceed possible ROF.
                enemy = hitData.collider.gameObject.GetComponent<BaseEnemy>();
                enemy.Suffer(Damage);
            }
        }
    }
}