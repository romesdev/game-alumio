using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class enemyCounter : MonoBehaviour
{
    public GameObject[] enemies;
    public Text enemyCountText;
    public string scenePass;
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");

        enemyCountText.text = "Enemies: " + enemies.Length.ToString();
        if(enemies.Length==0){
            SceneManager.LoadScene(scenePass);
        }
    }
}
