using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    private float spwanRange=9.0f;
    public  int enemyCount;
    public int waveNumber =0;
    public GameObject powerUpPrefab;

    void Start()
    {   
       
    }

    // Update is called once per frame
    void Update()
    {  
       enemyCount=FindObjectsOfType<Enemy>().Length;
       if (enemyCount==0){
        
           spwanEnemyWave(waveNumber);
           Instantiate(powerUpPrefab,generateSpwanPos(),powerUpPrefab.transform.rotation);
       }
    }
    
    private Vector3 generateSpwanPos() {
         float randomPosx=Random.Range(-spwanRange,spwanRange);
        float randomPosZ=Random.Range(-spwanRange,spwanRange );
        Vector3 spwanPos= new Vector3(randomPosx,0,randomPosZ);
        return spwanPos;

    }
    void spwanEnemyWave ( int enemiesToSpwan ) {
        for (int i =1;i<enemiesToSpwan;i++){
            Instantiate(enemyPrefab,generateSpwanPos(),enemyPrefab.transform.rotation);
        }
    }
}

