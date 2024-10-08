using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{public GameObject projectilePrefab;
 public float horizontalInput;
 public float forwardInput;
 public float speed = 10.0f;
 public float xRange = 200;
 public float zRange = 200;
    // Start is called before the first frame update
    void Start()
    {  
    }
    // Update is called once per frame
    void Update()
    {
    forwardInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        if(transform.position.x>xRange)
        {
             transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
    if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y, -zRange);
        }
        if(transform.position.z>zRange)
        {
             transform.position = new Vector3(transform.position.x,transform.position.y, zRange);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
             Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation);
        }
    }
}