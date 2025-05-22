using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ManagerDialogosMarcos : MonoBehaviour
{

    [SerializeField] private Diálogos dialogo;
    public bool c = false;
    public static ManagerDialogosMarcos Instance;

    private IEnumerator Start()
    {
        //Acto 1
       
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
        

        
        //yield return StartCoroutine(Minijuego("Minijuego Marcos"));
        
        SceneManager.LoadScene("Minijuego Marcos");
        
           /* dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
        
        

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 2);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 2);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 3);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 3);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 4);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 4);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 5);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 5);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 6);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 6);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 7);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);
        

        //Primera decisión
        dialogo.MostrarDecision1();

        yield return new WaitUntil(() => dialogo.D1Pos || dialogo.D1Neg);
        
        //Decisión buena
        if (dialogo.D1Pos)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
        }

        //Decisión mala
        if(dialogo.D1Neg)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
            
            yield break;
            //Aquí habría que poner algo para volver a la pantalla de inicio
        }

        

        //Acto 2
        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 7);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 8);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 8);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 9);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 9);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 10);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 10);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 11);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 11);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 12);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 12);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 13);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        //Segunda decision
        dialogo.MostrarDecision2();

        yield return new WaitUntil(() => dialogo.D2Pos || dialogo.D2Neg);

        //Decisión buena
        if (dialogo.D2Pos)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 3);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 4);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 4);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
        }

        //Decisión mala
        if (dialogo.D2Neg)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 3);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 3);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 4);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 4);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 5);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 5);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 6);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 7);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            yield break;
            //Aquí habría que poner algo para volver a la pantalla de inicio
        }

        //Acto 3
        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 13);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 14);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 14);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 15);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 15);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 16);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 16);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 17);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 17);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 18);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 18);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 19);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 19);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 20);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        //Tercera decision
        dialogo.MostrarDecision3();

        yield return new WaitUntil(() => dialogo.D3Pos || dialogo.D3Neg);

        if (dialogo.D3Pos)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 5);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 6);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosPos, 6);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 7);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroPos, 8);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            //Minijuego
        }

        //Decisión mala
        if (dialogo.D3Neg)
        {
            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 8);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 7);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 9);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 8);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 10);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 9);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 11);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 10);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 12);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 11);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 13);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 12);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 14);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 13);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 15);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.AlvaroNeg, 14);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 16);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 3);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.MarcosNeg, 17);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            yield break;
            //Aquí habría que poner algo para volver a la pantalla de inicio
        }

        //Minijuego

        //Final
        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 21);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 20);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 22);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 21);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 23);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 22);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 24);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 23);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 25);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 24);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 26);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 25);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 27);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 26);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 28);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 4);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 29);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 27);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 5);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);*/
    }
}
