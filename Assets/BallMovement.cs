using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float initalSpeed = 25f;
    int offscreen = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(9.8f * initalSpeed, 4.8f * initalSpeed));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
