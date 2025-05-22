using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugadorMarcos : MonoBehaviour
{
    private float velocidad = 5f;
    public int puntuacion=0;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private Vector2 movimiento;

    public static event System.Action OnMinijuegoFinished;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        movimiento.x = Input.GetAxis("Horizontal");
        //Debug.Log(puntuacion);
        if(puntuacion >= 10)
        {
            Time.timeScale = 0;
            Debug.Log("Ganaste");
            //OnMinijuegoFinished?.Invoke();
            SceneManager.LoadScene("Cita Marcos Final");
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
            puntuacion += 5;
            Destroy(collision.gameObject);
        }
    }
}
