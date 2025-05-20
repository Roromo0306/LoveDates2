using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerDialogosMarcos : MonoBehaviour
{

    [SerializeField] private Diálogos dialogo;
    

   

    private IEnumerator Start()
    {
        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Presentadora, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 0);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Marcos, 1);
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

        dialogo.EmpezarDialogoDesdeIndex(Diálogos.Personaje.Alvaro, 7);
        yield return new WaitUntil(() => !dialogo.IsPanelActive);
    }
}
