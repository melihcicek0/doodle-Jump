using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float ziplamahiz;
    private Vector2 karakterhiz;
    private Rigidbody2D fizik;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            fizik = collision.collider.GetComponent<Rigidbody2D>();
            if (fizik != null)
            {
                karakterhiz = fizik.velocity;
                karakterhiz.y = ziplamahiz;
                fizik.velocity = karakterhiz;
            }
        }
    }
}
