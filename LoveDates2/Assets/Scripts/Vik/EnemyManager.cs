using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemigo, balaEnemigo;
    public int filas = 5;
    public int columnas = 11;
    public Vector2 espacio = new Vector2(1.5f, 1.0f);
    public Vector2 inicio = new Vector2(-7.5f, 4f);

    public float velocidad = 0.5f;
    public float descendStep = 0.5f;
    private int direccion = 1;

    public float tiempoDisparoMin = 2f;
    public float tiempoDisparoMax = 5f;

    private List<Transform> enemigos = new List<Transform>();
    void Start()
    {
        for(int i =0; i<filas; i++)
        {
            for(int j=0; j<columnas; j++)
            {
                Vector3 pos = new Vector3(
                   inicio.x + j * espacio.x,
                   inicio.y - i * espacio.y,
                   0);
                GameObject e = Instantiate(enemigo, pos, Quaternion.identity, transform);
                enemigos.Add(e.transform);
            }
        }

        StartCoroutine(ProgramarDisparos());
    }

   
    void FixedUpdate()
    {
        if (enemigos.Count == 0) return;

        // Calcular movimiento horizontal
        Vector3 desplaz = Vector3.right * direccion * velocidad * Time.fixedDeltaTime;
        transform.position += desplaz;

        // Comprobar límites de pantalla (en unidades de mundo)
        float izquierdaPantalla = Camera.main.ViewportToWorldPoint(Vector3.zero).x;
        float derechaPantalla = Camera.main.ViewportToWorldPoint(Vector3.one).x;

        // Determinar el extremo de la formación
        float xMin = float.MaxValue, xMax = float.MinValue;
        foreach (var e in enemigos)
        {
            if (e == null) continue;
            xMin = Mathf.Min(xMin, e.position.x);
            xMax = Mathf.Max(xMax, e.position.x);
        }

        // Si toca un borde, bajar y cambiar de dirección
        if (xMax > derechaPantalla && direccion == 1 ||
            xMin < izquierdaPantalla && direccion == -1)
        {
            direccion *= -1;
            transform.position += Vector3.down * descendStep;
        }
    }

    private IEnumerator ProgramarDisparos()
    {
        while (enemigos.Count > 0)
        {
            yield return new WaitForSeconds(Random.Range(tiempoDisparoMin, tiempoDisparoMax));

            // Filtrar sólo los invasores más "bajos" (menor y)
            float minY = float.MaxValue;
            foreach (var e in enemigos) if (e != null) minY = Mathf.Min(minY, e.position.y);

            List<Transform> frontales = new List<Transform>();
            foreach (var e in enemigos)
            {
                if (e != null && Mathf.Approximately(e.position.y, minY))
                    frontales.Add(e);
            }

            if (frontales.Count == 0) continue;

            // Elige uno al azar y dispara
            Transform elegido = frontales[Random.Range(0, frontales.Count)];
            Instantiate(
                balaEnemigo,
                elegido.position + Vector3.down * 0.5f,
                Quaternion.identity
            );
        }
    }

    public void RemoveEnemy(Transform enemy)
    {
        enemigos.Remove(enemy);
    }
}
