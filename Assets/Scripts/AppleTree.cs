using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement
        // Changing direction
    }
}
