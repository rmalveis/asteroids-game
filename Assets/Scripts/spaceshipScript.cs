using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class spaceshipScript : MonoBehaviour
{
    public int Speed = 10;
    public GameObject bullet;
    public double BulletDistanceFromSpaceship = 0.5;

    // Update is called once per frame
    void Update()
    {
        // Exercise
        float horizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        // Extra
        float vertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        transform.Translate(horizontal, vertical, 0);

        if (Input.GetKeyDown("space"))
        {
            Vector3 bulletPosition = transform.position;
            bulletPosition.y = (float) (bulletPosition.y + BulletDistanceFromSpaceship);
            Instantiate(bullet, bulletPosition, Quaternion.identity);
        }
    }
}