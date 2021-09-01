using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthController : MonoBehaviour
{
    public compPlayer player;
    
    public float healthMax;

    public Image healthBar;


    //public float health = 2;
    public float Health {
        get {
            return player._vida;
        }
        set {
            player._vida = Mathf.Clamp(value, 0, healthMax);
        }
    }
    
   
    private void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Health += 0.5f;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Health -= 0.5f;
        }
        UpdateHealthBar();
    }

    private void UpdateHealthBar() {
        healthBar.fillAmount = Health / healthMax;
    }
}
