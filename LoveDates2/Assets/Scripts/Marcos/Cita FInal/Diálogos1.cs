using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Diálogos1 : MonoBehaviour
{
    
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcosPos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosMarcosNeg;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaro;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaroPos;
    [SerializeField, TextArea(1, 7)] private string[] dialgosAlvaroNeg;
    [SerializeField, TextArea(1, 7)] private string[] dialgosPresentadora;

    [SerializeField] public TextMeshProUGUI textoDial;
    [SerializeField] public GameObject Panel;
    public bool IsPanelActive => Panel.activeSelf;

    [HideInInspector] public enum Personaje { Marcos, Alvaro, Presentadora, MarcosPos, MarcosNeg, AlvaroPos, AlvaroNeg}

    private int index;
    private string[] dialogoAct;
    private bool escribiendo = false;
    private float velocEscrib = 0.05f;

    public Image D1_Pos, D1_Neg, D2_Pos, D2_Neg, D3_Pos, D3_Neg;
    public TextMeshProUGUI D1T_Pos, D1T_Neg, D2T_Pos, D2T_Neg, D3T_Pos, D3T_Neg;
    public Button D1_PosB, D1_NegB, D2_PosB, D2_NegB, D3_PosB, D3_NegB;
    [HideInInspector] public bool D1Pos = false, D1Neg = false, D2Pos = false, D2Neg = false, D3Pos = false, D3Neg = false;
    void Start()
    {
        D1_Pos.gameObject.SetActive(false);
        D1_Neg.gameObject.SetActive(false);
        D1T_Pos.gameObject.SetActive(false);
        D1T_Neg.gameObject.SetActive(false);

        D2_Pos.gameObject.SetActive(false);
        D2_Neg.gameObject.SetActive(false);
        D2T_Pos.gameObject.SetActive(false);
        D2T_Neg.gameObject.SetActive(false);

        D3_Pos.gameObject.SetActive(false);
        D3_Neg.gameObject.SetActive(false);
        D3T_Pos.gameObject.SetActive(false);
        D3T_Neg.gameObject.SetActive(false);

        D1_PosB.onClick.AddListener(() => D1PosB());
        D1_NegB.onClick.AddListener(() => D1NegB());

        D2_PosB.onClick.AddListener(() => D2PosB());
        D2_NegB.onClick.AddListener(() => D2NegB());

        D3_PosB.onClick.AddListener(() => D3PosB());
        D3_NegB.onClick.AddListener(() => D3NegB());

    }

    private void D1PosB()
    {
        D1Pos = true;
        D1_Pos.gameObject.SetActive(false);
        D1_Neg.gameObject.SetActive(false);
        D1T_Pos.gameObject.SetActive(false);
        D1T_Neg.gameObject.SetActive(false);
    }

    private void D1NegB()
    {
        D1Neg = true;
        D1_Pos.gameObject.SetActive(false);
        D1_Neg.gameObject.SetActive(false);
        D1T_Pos.gameObject.SetActive(false);
        D1T_Neg.gameObject.SetActive(false);
    }

    private void D2PosB()
    {
        D2Pos = true;
        D2_Pos.gameObject.SetActive(false);
        D2_Neg.gameObject.SetActive(false);
        D2T_Pos.gameObject.SetActive(false);
        D2T_Neg.gameObject.SetActive(false);
    }

    private void D2NegB()
    {
        D2Neg = true;
        D2_Pos.gameObject.SetActive(false);
        D2_Neg.gameObject.SetActive(false);
        D2T_Pos.gameObject.SetActive(false);
        D2T_Neg.gameObject.SetActive(false);
    }

    private void D3PosB()
    {
        D3Pos = true;
        D3_Pos.gameObject.SetActive(false);
        D3_Neg.gameObject.SetActive(false);
        D3T_Pos.gameObject.SetActive(false);
        D3T_Neg.gameObject.SetActive(false);
    }

    private void D3NegB()
    {
        D3Neg = true;
        D3_Pos.gameObject.SetActive(false);
        D3_Neg.gameObject.SetActive(false);
        D3T_Pos.gameObject.SetActive(false);
        D3T_Neg.gameObject.SetActive(false);
    }



    void Update()
    {
        
        if(Panel != null && Panel.activeSelf && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
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
                dialogoAct = dialgosMarcosNeg;
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

    public void MostrarDecision1()
    {
        Panel.SetActive(true);
        D1_Pos.gameObject.SetActive(true);
        D1T_Pos.gameObject.SetActive(true);
        D1_Neg.gameObject.SetActive(true);
        D1T_Neg.gameObject.SetActive(true);
    }

    public void MostrarDecision2()
    {
        Panel.SetActive(true);
        D2_Pos.gameObject.SetActive(true);
        D2T_Pos.gameObject.SetActive(true);
        D2_Neg.gameObject.SetActive(true);
        D2T_Neg.gameObject.SetActive(true);
    }

    public void MostrarDecision3()
    {
        Panel.SetActive(true);
        D3_Pos.gameObject.SetActive(true);
        D3T_Pos.gameObject.SetActive(true);
        D3_Neg.gameObject.SetActive(true);
        D3T_Neg.gameObject.SetActive(true);
    }

   /* private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        if (scene.name == "Cita Marcos") 
        {
            Panel = GameObject.Find("Panel"); 
            textoDial = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
            
        }
    }*/
}
