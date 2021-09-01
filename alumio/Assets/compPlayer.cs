using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class compPlayer : MonoBehaviour
{
    public float _vida = 10f;
    public string nomeDaCena;
  public void TomaDano(float dano){
    _vida -= dano;
    if(_vida<= 0){
      Morre();
    }
  }
  private void Morre(){
     SceneManager.LoadScene("MenuIniciar");
  }
}
