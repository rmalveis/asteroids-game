using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public float SpawnTime = 2;
    public GameObject Asteroid;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addEnemy", SpawnTime, SpawnTime);
    }

    void addEnemy()
    {
        Renderer renderer = GetComponent<Renderer>();
        var x1 = transform.position.x - renderer.bounds.size.x / 2;
        var x2 = transform.position.x + renderer.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(Asteroid, spawnPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}