using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorMarcos : MonoBehaviour
{
    private float velocidad = 5f;
    public int puntuacion=0;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private Vector2 movimiento;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        movimiento.x = Input.GetAxis("Horizontal");
        if(puntuacion == 10)
        {
            Time.timeScale = 0;
            Debug.Log("Ganaste");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Billete"))
        {
            puntuacion += 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Billete2"))
        {
            puntuacion += 2;
            Destroy(collision.gameObject);
        }
    }
}
