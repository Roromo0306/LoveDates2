using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CuentaAtrás : MonoBehaviour
{
    public int inicioTiempo = 30;
    public TextMeshProUGUI cuentaText;
    void Start()
    {
        StartCoroutine(Cuenta(inicioTiempo));
    }

    
    IEnumerator Cuenta (int n)
    {
        int r = n;
        while (r > 0)
        {
            int minutos = r / 60;
            int segundos = r % 60;
            cuentaText.text = $"{minutos:00}:{segundos:00}";
            yield return new WaitForSeconds(1f);
            r--;
        }
        cuentaText.text = "00:00";
        ads();
    }

    private void ads()
    {
        Debug.Log("Tiempo acabado");
        Time.timeScale = 0;
    }
}
