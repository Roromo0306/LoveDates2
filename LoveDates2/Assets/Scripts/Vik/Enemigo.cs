using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private EnemyManager manager;

    void Start()
    {
        manager = GetComponentInParent<EnemyManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BalaJ")
        {
            Destroy(this.gameObject);
        }
    }
}
