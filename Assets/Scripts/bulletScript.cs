using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class bulletScript : MonoBehaviour
{
    public int Speed = 6;
    private GameObject _scoreText;

    // Use this for initialization
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Speed);
        _scoreText = GameObject.FindGameObjectWithTag("score");
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("asteroid")) return;

        _scoreText.GetComponent<scoreScript>().Score += 10;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}