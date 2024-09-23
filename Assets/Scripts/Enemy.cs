using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    public int enemyCount;

    public int Length { get; internal set; }

    void Start()
    {
      enemyRb=GetComponent<Rigidbody>() ; 
      player=GameObject.Find("Player");
    
    }

    // Update is called once per frame
    void Update()
    {  
      Vector3 lookDirection =  (player.transform.position-transform.position).normalized;
      enemyRb.AddForce(lookDirection*speed)  ;
      if (transform.position.y<-10){
        Destroy(gameObject);
      }

      

    }
}
