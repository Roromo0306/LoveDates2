using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour
{
    public float velocidad = 10f;
    private GameObject player;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * velocidad;
        player = GameObject.Find("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JugadorVik j = player.GetComponent<JugadorVik>();
        if (collision.gameObject.tag=="Edge")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemigo")
        {
            j.puntuacion += 1;
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }
}
