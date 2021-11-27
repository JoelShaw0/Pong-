using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRebound : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 previousSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        previousSpeed = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = previousSpeed.magnitude;
        var direction = Vector3.Reflect(previousSpeed.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
