using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billete : MonoBehaviour
{
    public float velocCaida = 1f;   
    public float amplitud = 0.5f; 
    public float frecuencia = 1f;   

    private float posX;
    private float elapsed;

    void Start()
    {
        posX = transform.position.x;
        elapsed = 0f;
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null) rb.gravityScale = 0f;
    }

    void Update()
    {
        elapsed += Time.deltaTime;

        float offsetX = Mathf.Sin(elapsed * frecuencia * 2f * Mathf.PI) * amplitud;

        Vector3 pos = transform.position;
        pos.x = posX + offsetX;
        pos.y -= velocCaida * Time.deltaTime;
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Edge"))
        {
            Destroy(this.gameObject);
        }
    }

}
