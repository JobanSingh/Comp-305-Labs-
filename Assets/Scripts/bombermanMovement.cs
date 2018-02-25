using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombermanMovement : MonoBehaviour {

    public float maxSpeed = 10.0f;
    private Rigidbody2D rbody;
   

    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

     
        rbody.velocity = new Vector2(moveHorizontal * maxSpeed, moveVertical*maxSpeed);

    }

    }
   


