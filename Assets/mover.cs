using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    Rigidbody  rb;
    
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }

    void moveplayer()
    {
        
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector3(0,rb.velocity.y,5);
        }

        if(Input.GetKey(KeyCode.UpArrow)){
            rb.velocity = new Vector3(rb.velocity.x,5,0);
        }
       
    }
}