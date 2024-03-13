using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseEnemy : MonoBehaviour
{
    //Health Points, Movement Speed, Score Reward
    [Header("Attributes")]
    public int HP;
    public float SPD;
    public int SCR;

    void Start()
    {
        
    }

    virtual protected void Attack(){}

    virtual protected void Move()
    {
        transform.Translate((PlayerController.Instance.gameObject.transform.position - transform.position).normalized * SPD * Time.deltaTime);
    }

    //Subtract damage from HP.
    public void Suffer(int damage)
    {
        HP -= damage;
        if (HP <= 0)
            Die();
        //flash red.
    }

    virtual protected void Die()
    {
        Debug.Log("DIE");
        Destroy(gameObject);
    }

    virtual protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("WHY");
            Die();
            GameManager.Instance.Lives--;
        }
    }
}
