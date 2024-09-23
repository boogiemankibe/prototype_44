using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    private GameObject focalPoint;
    private Rigidbody playerRb;
    public bool haspowerUP=false;
    public  GameObject powerUpIndicator;
    void Start()
    {
       playerRb=GetComponent<Rigidbody>(); 
       focalPoint=GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwadInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwadInput );
        powerUpIndicator.transform.position=transform.position + new Vector3(0,-0.14f,0);
         

    }
    
    
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("powerUp")){
            haspowerUP=true;
            powerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(powerUpCountDownRoutine());


        }
    
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Enemy")&&haspowerUP){
            Debug.Log("collided with:" + collision.gameObject.name+"with powerup set to" + haspowerUP);
        }
    }
    IEnumerator powerUpCountDownRoutine() {
        yield return new WaitForSeconds(4);
        haspowerUP=false;
        powerUpIndicator.gameObject.SetActive(false);

    }
}
