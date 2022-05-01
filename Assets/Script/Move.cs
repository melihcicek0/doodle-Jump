using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D dodle;
    private float hareket;
    void Update()
    {
        hareket = Input.GetAxis("Horizontal");
        dodle.velocity = new Vector2(hiz * hareket, dodle.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "over")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
