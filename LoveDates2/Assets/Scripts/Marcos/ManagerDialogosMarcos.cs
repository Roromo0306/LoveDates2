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

    }
}
