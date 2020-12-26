using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{
   
    public float speed = 5.0f;
    // Start is called before the first frame update
    Rigidbody player; 
    void Start()
    {
         player = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        print(player.name + "'s position: " + player.position);
    }

    public void Movement()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(-transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }

}
