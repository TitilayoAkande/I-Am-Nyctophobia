using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Animator anim;
    public int playerHealth = 200;
    private int currentHealth;
    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHealth;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

     public void TakeDamage(int damage)
    {
        currentHealth -= damage;


        if(currentHealth <= 0)
        {
            
            Die();
        }

        healthBar.SetHealth(currentHealth);
    }

    void Die() 
    {
        Debug.LogFormat("Player Died!");


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        anim.SetTrigger("died");
       
    }
}
