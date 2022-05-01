using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        float rastgeleX = Random.Range(-5.4f, 5.4f);
        float y = 18.1f;
        if (collision.tag == "platform")
        {
            collision.transform.position = new Vector3(rastgeleX, collision.transform.position.y+y,collision.transform.position.z);
        }
    }
}
