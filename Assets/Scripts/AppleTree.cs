﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Prefab for instatiating objects 
    public GameObject applePrefab;

    // Speed at which the AppleTree moves in meters/second
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change direction
    public float chanceToChangeDirection = 0.1f;

    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Dropping Apples every second
        InvokeRepeating( "DropApple", 2f, secondsBetweenAppleDrops );
    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement
        Vector3 pos = transform.position;
        pos.x += speed*Time.deltaTime;
        transform.position = pos;
        // Changing direction
        if ( pos.x < -leftAndRightEdge ) {
            speed = Mathf.Abs(speed);  // Move right
        } else if ( pos.x > leftAndRightEdge ) {
            speed = -Mathf.Abs(speed); // Move left
        }
        
    }

    void FixedUpdate() {
        // Change direction randomly 
        if ( Random.value < chanceToChangeDirection ) {
            speed *= -1; 
        }    
    }
    void DropApple() {
        GameObject apple = Instantiate( applePrefab ) as GameObject;
        apple.transform.position = transform.position;
    }
}
