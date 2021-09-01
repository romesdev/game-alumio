using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackScript : MonoBehaviour
{
    public float dano;

    private void OnTriggerEnter2D(Collider2D collision) {
       if(collision.gameObject.tag.Equals("Player")){
           var inimigoObj = collision.GetComponent<compPlayer>();
           inimigoObj.TomaDano(dano);
       }
   }
    
}
