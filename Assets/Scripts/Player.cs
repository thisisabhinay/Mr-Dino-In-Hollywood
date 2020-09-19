﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float input;

    Rigidbody2D rb;
    Animator anime;

    // Start is called before the first frame update
    void Start(){
        anime = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    private void Update(){
        bool flag = input != 0 ? true : false;
        anime.SetBool ("isRunning", flag);
    }

    void FixedUpdate(){
        // Storing player's input
        input = Input.GetAxisRaw("Horizontal");

        // Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}