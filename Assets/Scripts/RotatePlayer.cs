using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotataionalSpeed=50.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float  horizontalSpeed=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up ,horizontalSpeed*rotataionalSpeed*Time.deltaTime);
    }
}
