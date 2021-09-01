using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randowSpawner : MonoBehaviour
{
    public Transform[]   spawnPoins;
    public GameObject[]  enemyFabs;

    public int maxSpawn;
    public int tamanhoDaOrda;
    public float StartTimeSpawn;
    public float timeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawn = StartTimeSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if(maxSpawn>0){
            if(timeBtwSpawn<=0){
                int randowSpawPoint = Random.Range(0,spawnPoins.Length);
            for(int i=0; i<tamanhoDaOrda;i++){
                int randEnemy = Random.Range(0,enemyFabs.Length);    
                Instantiate(enemyFabs[randEnemy],spawnPoins[randowSpawPoint].position,transform.rotation);
            }
                maxSpawn-=1;
            } else {
                timeBtwSpawn = Time.deltaTime;
            }
        }
    }
}
