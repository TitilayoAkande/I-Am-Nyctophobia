using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackArea : MonoBehaviour
{
     public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;
    public float attackRate = 2f;
    public float nextAttackTime = 0f;
    private bool attackBlocked;
    public float time;

    void Update() 
    {   
            if(Time.time >= nextAttackTime)
            {
            
                if(Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        
                        Attack();
                        nextAttackTime = Time.time +  1f / attackRate;


                    }
            }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
       
        foreach(Collider2D enemy in hitEnemies)
        {
           Debug.Log("We hit " + enemy.name);

           enemy.GetComponent<EnemyHealth>().TakeDamage(40);
        }

        
    }

     void OnDrawGizmosSelected() 
    {
        if(attackPoint == null)
        {
            return;
        }
       Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}
