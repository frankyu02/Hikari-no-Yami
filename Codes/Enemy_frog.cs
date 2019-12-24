using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_frog : MonoBehaviour

{
    public int health=50;
    public GameObject deathEffect;
    // Start is called before the first frame update
    public void TakeDamage(int damage){
        health-=damage;
        if(health<=0){  
            Die();
        }
    }
     void Die(){
        GameObject particle= Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(particle,0.5f);
        }
}
