using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class bulletScript : MonoBehaviour
{
    public int Speed = 6;

    // Use this for initialization
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}