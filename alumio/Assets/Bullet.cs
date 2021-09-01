using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
 
   public float dano = 2f;

   public GameObject hitEffect;   
   void OnCollisionEnter2D(Collision2D collision) {
       GameObject effect =  Instantiate(hitEffect,transform.position,Quaternion.identity); 
       Destroy(effect,0.5f); 
       Destroy(gameObject);
   }
   private void OnTriggerEnter2D(Collider2D collision) {
       if(collision.gameObject.tag.Equals("enemy")){
           var inimigoObj = collision.GetComponent<compEnemy>();
           inimigoObj.TomaDano(dano);
       }
   }
}
