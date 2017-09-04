using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using UnityEngine;
using UnityEngine.UI;

public class spaceshipScript : MonoBehaviour
{
    public int Speed = 10;
    public GameObject Bullet;
    public GUIText LifeGui;

    private int _life = 3;

    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * Speed *
                         Time.deltaTime;
        transform.Translate(horizontal, 0, 0); // Aplicando as mudanças

        if (transform.position.x <= -5.6f || transform.position.x >= 5.6f)
        {
            var xPos = Mathf.Clamp(transform.position.x, -5.6f, 5.6f);
            transform.position = new Vector3(xPos, transform.position.y,
                transform.position.z);
        }

        if (Input.GetKeyDown("space"))
        {
            // Cria uma nova bala na posiçao atual da nave para que siga a nave
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }

        LifeGui.text = "Vidas: " + _life;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("asteroid")) return;

        Destroy(other.gameObject);
        _life = _life - 1;

        if (_life == 0)
        {
            Destroy(this.gameObject);
        }
    }
}