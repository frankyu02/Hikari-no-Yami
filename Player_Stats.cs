using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    public int health=100;
   public void damage(int damage){
       health-=damage;
       if(health>=0){
           die();
       }
   }
   public void die(){
       Destroy(gameObject);
   }
}
