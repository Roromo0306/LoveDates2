using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diálogos : MonoBehaviour
{
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcosPos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcosNeg;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaro;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaroPos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaroNeg;
    [SerializeField, TextArea(1, 7)] private string[] dialgosPresentadora;

    [SerializeField] private TextMeshProUGUI textoDial;
    [SerializeField] private GameObject Panel;
    public bool IsPanelActive => Panel.activeSelf;

    [HideInInspector] public enum Personaje { Marcos, Alvaro, Presentadora, MarcosPos, MarcosNeg, AlvaroPos, AlvaroNeg}

    private int index;
    private string[] dialogoAct;
    private bool escribiendo = false;
    private float velocEscrib = 0.05f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Panel.activeSelf && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (!escribiendo)
            {
                Siguientefrase();
                
            }
            else
            {
                StopAllCoroutines();
                textoDial.text = dialogoAct[index];
                escribiendo = false;
            }
        } 
    }

    public void EmpezarDialogo(Personaje personaje)
    {
        index = 0;

        switch (personaje)
        {
            case Personaje.Marcos:
                dialogoAct = dialgosMarcos;
                break;
            case Personaje.Alvaro:
                dialogoAct= dialgosAlvaro;
                break;
            case Personaje.Presentadora:
                dialogoAct = dialgosPresentadora;
                break;
            case Personaje.MarcosPos:
                dialogoAct = dialgosMarcosPos;
                break;
            case Personaje.AlvaroPos:
                dialogoAct = dialgosAlvaroPos;
                break;
            case Personaje.MarcosNeg:
                dialogoAct = dialgosMarcosPos;
                break;
            case Personaje.AlvaroNeg:
                dialogoAct = dialgosAlvaroNeg;
                break;
        }

        Panel.SetActive(true);
        Siguientefrase();
    }

    public void Siguientefrase()
    {
     
        FindD();
    }

    public IEnumerator EscribirFrase(string frase)
    {
        escribiendo = true;
        textoDial.text = string.Empty;
        foreach(char letra in frase.ToCharArray())
        {
            textoDial.text += letra;
            yield return new WaitForSeconds(velocEscrib);
        }
        escribiendo = false;
        
    }

    public void EmpezarDialogoDesdeIndex(Personaje personaje, int indexX)
    {
        switch (personaje)
        {
            case Personaje.Marcos:
                dialogoAct = dialgosMarcos;
                break;
            case Personaje.Alvaro:
                dialogoAct = dialgosAlvaro;
                break;
            case Personaje.Presentadora:
                dialogoAct = dialgosPresentadora;
                break;
            case Personaje.MarcosPos:
                dialogoAct = dialgosMarcosPos;
                break;
            case Personaje.AlvaroPos:
                dialogoAct = dialgosAlvaroPos;
                break;
            case Personaje.MarcosNeg:
                dialogoAct = dialgosMarcosNeg;
                break;
            case Personaje.AlvaroNeg:
                dialogoAct = dialgosAlvaroNeg;
                break;
        }

        index = indexX;
        Panel.SetActive(true);
        StartCoroutine(EscribirFrase(dialogoAct[index]));
        index++;
    }
    public void FindD()
    {
        Panel.SetActive(false);
    }
}
