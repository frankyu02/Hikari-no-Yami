using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public float movespeed=5f;
    public bool isGrounded=false;
    public bool facingright;
    
    public bool isdead=false;
    public static GameObject gm;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(gm=null){
            gm=GameObject.FindGameObjectWithTag("Player");
        }
        facingright=true;
    }
    public Trasform playersprite;
    public Transform spawnpoint;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal=Input.GetAxis("Horizontal");
        Jump();
        float horizontalmove= Input.GetAxisRaw("Horizontal")*movespeed;
        Vector3 movement= new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        animator.SetFloat("speed", Mathf.Abs(horizontalmove));  
        transform.position +=movement*Time.deltaTime*movespeed;
        Flip(horizontal);
        deathcheck();
       
    }
    private void Jump(){
        if(Input.GetButtonDown("Jump")&&isGrounded==true){  
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,15f), ForceMode2D.Impulse);
        
        }
        
        
    }
    private void Flip(float horizontal){
        if(horizontal>0&& !facingright || horizontal<0 && facingright){
            facingright=!facingright;
            transform.Rotate(0f,180f,0);
        }
    }
    private void landcheck(){
        if (isGrounded==true){
            animator.SetBool("isjumping",false);
        }
    }
    private void deathcheck(){
        if(isdead==true){
            Destroy(gameObject);
        }
    }
    public void Respawn(){

    }
    
    
}
