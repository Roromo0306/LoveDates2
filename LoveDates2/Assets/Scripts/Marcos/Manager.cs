using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9, prefabB1, prefabB2;
    private GameObject player;

    
    void Start()
    {
        player = GameObject.Find("Player");
        InvokeRepeating("Instanciar", Random.Range(1f, 3f), Random.Range(1f, 5f));
    }

   
    void Update()
    {
        
    }

    private void Instanciar()
    {
        int randomPrefab = Random.Range(1, 3);
        int randomSpawn = Random.Range(1, 10);

        Debug.Log("Random pregab es " + randomPrefab + " y random spawn " + randomSpawn);
        if(randomPrefab == 1)
        {
            if(randomSpawn == 1)
            {
               GameObject n= Instantiate(prefabB1, s1.transform.position, s1.transform.rotation);
               n.transform.SetParent(s1.transform);
                
            }

            if (randomSpawn == 2)
            {
                GameObject n = Instantiate(prefabB1, s2.transform.position, s2.transform.rotation);
                n.transform.SetParent(s2.transform);
            }

            if (randomSpawn == 3)
            {
                GameObject n = Instantiate(prefabB1, s3.transform.position, s3.transform.rotation);
                n.transform.SetParent(s3.transform);
            }

            if (randomSpawn == 4)
            {
                GameObject n = Instantiate(prefabB1, s4.transform.position, s4.transform.rotation);
                n.transform.SetParent(s4.transform);
            }

            if (randomSpawn == 5)
            {
                GameObject n = Instantiate(prefabB1, s5.transform.position, s5.transform.rotation); 
                n.transform.SetParent(s5.transform);
            }

            if (randomSpawn == 6)
            {
                GameObject n = Instantiate(prefabB1, s6.transform.position, s6.transform.rotation);
                n.transform.SetParent(s6.transform);
            }

            if (randomSpawn == 7)
            {
                GameObject n = Instantiate(prefabB1, s7.transform.position, s7.transform.rotation);
                n.transform.SetParent(s7.transform);
            }

            if (randomSpawn == 8)
            {
                GameObject n = Instantiate(prefabB1, s8.transform.position, s8.transform.rotation);
                n.transform.SetParent(s8.transform);
            }

            if (randomSpawn == 9)
            {
                GameObject n = Instantiate(prefabB1, s9.transform.position, s9.transform.rotation);
                n.transform.SetParent(s9.transform);
            }
        } 

        if(randomPrefab == 2)
        {
            if (randomSpawn == 1)
            {
                GameObject n = Instantiate(prefabB2, s1.transform.position, s1.transform.rotation);
                n.transform.SetParent(s1.transform);
            }

            if (randomSpawn == 2)
            {
                GameObject n = Instantiate(prefabB2, s2.transform.position, s2.transform.rotation);
                n.transform.SetParent(s2.transform);
            }

            if (randomSpawn == 3)
            {
                GameObject n = Instantiate(prefabB2, s3.transform.position, s3.transform.rotation);
                n.transform.SetParent(s3.transform);
            }

            if (randomSpawn == 4)
            {
                GameObject n = Instantiate(prefabB2, s4.transform.position, s4.transform.rotation);
                n.transform.SetParent(s4.transform);
            }

            if (randomSpawn == 5)
            {
                GameObject n = Instantiate(prefabB2, s5.transform.position, s5.transform.rotation);
                n.transform.SetParent(s5.transform);
            }

            if (randomSpawn == 6)
            {
                GameObject n = Instantiate(prefabB2, s6.transform.position, s6.transform.rotation);
                n.transform.SetParent(s6.transform);
            }

            if (randomSpawn == 7)
            {
                GameObject n = Instantiate(prefabB2, s7.transform.position, s7.transform.rotation);
                n.transform.SetParent(s7.transform);
            }

            if (randomSpawn == 8)
            {
                GameObject n = Instantiate(prefabB2, s8.transform.position, s8.transform.rotation);
                n.transform.SetParent(s8.transform);
            }

            if (randomSpawn == 9)
            {
                GameObject n = Instantiate(prefabB2, s9.transform.position, s9.transform.rotation);
                n.transform.SetParent(s9.transform);
            }
        }

    }
}
