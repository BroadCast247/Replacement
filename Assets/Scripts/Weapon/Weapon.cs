using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public WeaponSetting weaponSettings;
    private SpriteRenderer sr;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    public void OnAttack()
    {
        
    }

    public float GetROF()
    {
        return weaponSettings.ROF;
    }

    public int GetAttack()
    {
        return weaponSettings.ATK;
    }
}
