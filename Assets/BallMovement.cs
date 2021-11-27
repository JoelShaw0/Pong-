using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float initalSpeed = 100f;
    // Start is called before the first frame update
    /*private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }*/

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(9.8f * 25f, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.velocity = new Vector2(initalSpeed, 0f) * Time.deltaTime;
    }
}
