using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugadorVik : MonoBehaviour
{

    private float velocidad = 5f;
    public int puntuacion;
    public int vidas = 5;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private Vector2 movimiento;

    public GameObject balaJugador;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        movimiento.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }

        if(puntuacion == 55)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Cita Vik Final");
        }

        if(vidas <= 0)
        {
            Destroy(this.gameObject);
            Time.timeScale = 0;
            SceneManager.LoadScene("Gameover Vik");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento*velocidad * Time.fixedDeltaTime);
    }

    private void Disparar()
    {
        Instantiate(balaJugador, transform.position+ new Vector3(0, 0.4f, 0), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemigo")
        {
            Destroy(this.gameObject);
            Time.timeScale = 0;
            Debug.Log("Has Perdido");
        }
    }
}
