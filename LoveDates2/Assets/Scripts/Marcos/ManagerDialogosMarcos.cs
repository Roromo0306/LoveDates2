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

    }
}
