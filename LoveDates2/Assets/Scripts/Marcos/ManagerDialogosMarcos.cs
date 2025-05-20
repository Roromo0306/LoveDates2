using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerDialogosMarcos : MonoBehaviour
{

    [SerializeField] private Di�logos dialogo;
    

   

    private IEnumerator Start()
    {
        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Presentadora, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 1);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 1);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 2);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 2);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 3);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 3);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 4);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 4);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 5);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 5);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 6);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 6);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Marcos, 7);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        //Primera decisi�n
        dialogo.MostrarDecision1();

        yield return new WaitUntil(() => dialogo.D1Pos || dialogo.D1Neg);
        
        //Decisi�n buena
        if (dialogo.D1Pos)
        {
            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosPos, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.AlvaroPos, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosPos, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.AlvaroPos, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosPos, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
        }

        //Decisi�n mala
        if(dialogo.D1Neg)
        {
            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosNeg, 0);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.AlvaroNeg, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosNeg, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Presentadora, 1);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);

            dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.MarcosNeg, 2);
            yield return new WaitUntil(() => !dialogo.IsPanelActive);
            
            yield break;
            //Aqu� habr�a que poner algo para volver a la pantalla de inicio
        }

        dialogo.EmpezarDialogoDesdeIndex(Di�logos.Personaje.Alvaro, 7);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);
    }
}
