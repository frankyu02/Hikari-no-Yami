using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=5f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity=transform.right*speed;
    }
    void OnTriggerEnter2D(Collider2D hit){

        Enemy_frog enemy= hit.GetComponent<Enemy_frog>();
        if(enemy!=null){
            enemy.TakeDamage(10);
        }
        Destroy(gameObject);
    }
    // Update is called once per frame
   
}
