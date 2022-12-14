using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

     public Animator animator;
    public int enemyHealth = 500;
    public int currentHealth;
    public EnemyHealthBar enemyHealthBar;
    // Start is called before the first frame update
    void Start()
    {
         currentHealth = enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            
            Die();
        }

        enemyHealthBar.SetHealth(currentHealth);
    }


    void Die() 
    {
        Debug.LogFormat("Player Died!");

        animator.SetBool("IsDied", true);
        
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
       
       
    }
}
