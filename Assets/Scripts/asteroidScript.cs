using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidScript : MonoBehaviour
{
    public int Speed = -5;

    // Use this for initialization
    void Start()
    {
        // Adicionar speed à velocidade do asteroide
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Speed);

        // Faz o asteroide rodar em si mesmo aleatoriamentre entre -200 e 200 graus
        rb.angularVelocity = Random.Range(-200, 200);

        // Destroi o asteroide após 3s, que ele não está mais visível na tela
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
    }
}