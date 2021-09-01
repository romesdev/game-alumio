using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compEnemy : MonoBehaviour
{
  
  public float _vida = 10f;

  public void TomaDano(float dano){
    _vida -= dano;
    if(_vida<= 0){
      Morre();
    }
  }
  private void Morre(){
    Destroy(gameObject);
  }
}
